using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_4b45-2bac55db")]
        public void /* sys */ Method_1019_4b45()
        {
            ii(0x1019_4b45, 1); push(ebp);                              /* push ebp */
            ii(0x1019_4b46, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_4b48, 1); push(esi);                              /* push esi */
            ii(0x1019_4b49, 1); push(edi);                              /* push edi */
            ii(0x1019_4b4a, 1); push(ebx);                              /* push ebx */
            ii(0x1019_4b4b, 1); push(ecx);                              /* push ecx */
            ii(0x1019_4b4c, 2); pushd(fs);                              /* push fs */
            ii(0x1019_4b4e, 2); pushd(gs);                              /* push gs */
            ii(0x1019_4b50, 1); pushd(es);                              /* push es */
            ii(0x1019_4b51, 7); cmp(memd[ds, 0x101c_1a54], 0);          /* cmp dword [0x101c1a54], 0x0 */
            ii(0x1019_4b58, 2); if(jz(0x1019_4b66, 0xc)) goto l_0x1019_4b66; /* jz 0x10194b66 */
            ii(0x1019_4b5a, 1); nop();                                  /* nop */
            ii(0x1019_4b5b, 1); nop();                                  /* nop */
            ii(0x1019_4b5c, 1); nop();                                  /* nop */
            ii(0x1019_4b5d, 1); nop();                                  /* nop */
            ii(0x1019_4b5e, 4); mov(dx, 0x21);                          /* mov dx, 0x21 */
            ii(0x1019_4b62, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1019_4b63, 2); or(al, 1);                              /* or al, 0x1 */
            ii(0x1019_4b65, 1); outb(dx, al);                           /* out dx, al */
        l_0x1019_4b66:
            ii(0x1019_4b66, 1); popd(es);                               /* pop es */
            ii(0x1019_4b67, 2); popd(gs);                               /* pop gs */
            ii(0x1019_4b69, 2); popd(fs);                               /* pop fs */
            ii(0x1019_4b6b, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_4b6c, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_4b6d, 1); pop(edi);                               /* pop edi */
            ii(0x1019_4b6e, 1); pop(esi);                               /* pop esi */
            ii(0x1019_4b6f, 1); pop(ebp);                               /* pop ebp */
            ii(0x1019_4b70, 1); ret();                                  /* ret */
        }
    }
}
