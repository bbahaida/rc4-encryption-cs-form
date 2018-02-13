using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoRC4
{
    class CryptoRC4Engine
    {
        #region Private Fields

        // clé de chiffrement UNICODE
        private string _encryptionKey = "";

        // clé de chiffrement ASCII
        private string _encryptionKeyAscii = "";

        // Longueur de la clé
        static public long _keyLength = 256;

        // Le tableau S[]
        protected byte[] _sArray = new byte[_keyLength];

        // texte claire 
        private string _clearText = "";

        // texte chiffré 
        private string _cryptedText = "";

        #endregion

        #region Properties

        public string EncryptionKey
        {
            get
            {
                return (this._encryptionKey);
            }
            set
            {
                if (this._encryptionKey != value)
                {
                    this._encryptionKey = value;
                    ksa();
                }
                
            }
        }
        public string CryptedText
        {
            get
            {
                return (this._cryptedText);
            }
            set
            {
                if (this._cryptedText != value)
                {
                    this._cryptedText = value;
                }
            }
        }

        public string ClearText
        {
            get
            {
                return (this._clearText);
            }
            set
            {
                if (this._clearText != value)
                {
                    this._clearText = value;
                }
            }
        }
        #endregion

        #region Public Method
        
        public bool Encrypt()
        {
            //
            // toRet est utilisé pour mémoriser le retcode de la methode
            //
            bool toRet = true;

            try
            {
                
                long i = 0;
                long j = 0;

                //
                // Mettre le texte claire dans le tableau d'octets temporaire
                //
                Encoding enc_default = Encoding.Default;
                byte[] input = enc_default.GetBytes(this._clearText);

                // 
                // Tableau d'octets de sortie
                //
                byte[] output = new byte[input.Length];

                //
                // Une copie locale de S[]
                //
                byte[] n_LocBox = new byte[_keyLength];
                this._sArray.CopyTo(n_LocBox, 0);

                //
                //	Longueur du Cipher
                //
                long ChipherLen = input.Length + 1;

                //
                // Exécuter l'Alghoritm PRGA
                //
                for (long offset = 0; offset < input.Length; offset++)
                {
                    i = (i + 1) % _keyLength;
                    j = (j + n_LocBox[i]) % _keyLength;
                    byte temp = n_LocBox[i];
                    n_LocBox[i] = n_LocBox[j];
                    n_LocBox[j] = temp;
                    byte a = input[offset];
                    byte b = n_LocBox[(n_LocBox[i] + n_LocBox[j]) % _keyLength];
                    output[offset] = (byte)((int)a ^ (int)b);
                }

                //
                // Mettre le résultat dans la chaîne de sortie ( CryptedText )
                //
                char[] outarrchar = new char[enc_default.GetCharCount(output, 0, output.Length)];
                enc_default.GetChars(output, 0, output.Length, outarrchar, 0);
                this._cryptedText = new string(outarrchar);
            }
            catch
            {
                //
                // erreur s'est produite - définir le retcode sur false.
                // 
                toRet = false;
            }

            
            return (toRet);

        }
        
        public bool Decrypt()
        {
            //
            // toRet est utilisé pour mémoriser le retcode de la methode
            //

            bool toRet = true;

            try
            {
                this._clearText = this._cryptedText;
                _cryptedText = "";
                if (toRet = Encrypt())
                {
                    _clearText = _cryptedText;
                }

            }
            catch
            {
                //
                // erreur s'est produite - définir le retcode sur false.
                // 
                toRet = false;
            }
            
            return toRet;
        }

        #endregion
        private void ksa()
        {
            long j = 0;

            //
            // Créez deux encodages différents 
            //
            Encoding ascii = Encoding.ASCII;
            Encoding unicode = Encoding.Unicode;

            //
            // Effectuer la conversion de la clé de cryptage d'unicode en ascii
            //
            byte[] asciiBytes = Encoding.Convert(unicode, ascii, unicode.GetBytes(_encryptionKey));

            //
            // Convertir le nouvel byte[] en un chars[] et ensuite en string
            //

            char[] asciiChars = new char[ascii.GetCharCount(asciiBytes, 0, asciiBytes.Length)];
            ascii.GetChars(asciiBytes, 0, asciiBytes.Length, asciiChars, 0);
            this._encryptionKeyAscii = new string(asciiChars);

            
            long userKeyLength = _encryptionKey.Length;

            //
            // Init S
            //
            for (long i = 0; i < _keyLength; i++)
            {
                this._sArray[i] = (byte)i;
            }

            //
            // Exécuter l'Alghoritm KSA
            //
            for (long i = 0; i < _keyLength; i++)
            {
                j = (j + _sArray[i] + asciiChars[i % userKeyLength]) % _keyLength;
                byte temp = _sArray[i];
                _sArray[i] = _sArray[j];
                _sArray[j] = temp;
            }
        }
        
    }
}
