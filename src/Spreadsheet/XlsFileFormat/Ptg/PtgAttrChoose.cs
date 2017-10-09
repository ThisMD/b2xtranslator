using System.Diagnostics;
/*
 * Copyright (c) 2008, DIaLOGIKa
 * All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions are met:
 *     * Redistributions of source code must retain the above copyright
 *       notice, this list of conditions and the following disclaimer.
 *     * Redistributions in binary form must reproduce the above copyright
 *       notice, this list of conditions and the following disclaimer in the
 *       documentation and/or other materials provided with the distribution.
 *     * Neither the name of DIaLOGIKa nor the
 *       names of its contributors may be used to endorse or promote products
 *       derived from this software without specific prior written permission.
 *
 * THIS SOFTWARE IS PROVIDED BY DIaLOGIKa ''AS IS'' AND ANY
 * EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
 * WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
 * DISCLAIMED. IN NO EVENT SHALL DIaLOGIKa BE LIABLE FOR ANY
 * DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
 * (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
 * LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
 * ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
 * (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
 * SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 */
using DIaLOGIKa.b2xtranslator.StructuredStorage.Reader;

namespace DIaLOGIKa.b2xtranslator.Spreadsheet.XlsFileFormat.Ptg
{
    public class PtgAttrChoose : AbstractPtg
    {
        public const Ptg0x19Sub ID = Ptg0x19Sub.PtgAttrChoose;

        public PtgAttrChoose(IStreamReader reader, Ptg0x19Sub ptgid)
            :
            base(reader, ptgid)
        {
            Debug.Assert((Ptg0x19Sub)this.Id == ID);
            this.Length = 4;
            this.Data = "Semi";
            this.type = PtgType.Operator;
            this.popSize = 1;
            uint cOffset = this.Reader.ReadUInt16();
            for (int i = 0; i <= cOffset; i++)
            {
                this.Reader.ReadUInt16(); 
            }
            this.Length += (cOffset+1) * 2; 
        }
    }
}
