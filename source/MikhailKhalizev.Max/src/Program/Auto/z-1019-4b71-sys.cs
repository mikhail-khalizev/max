using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_4b71-62dd950c")]
        public void /* sys */ Method_1019_4b71()
        {
            ii(0x1019_4b71, 1); push(ebp);                              /* push ebp */
            ii(0x1019_4b72, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_4b74, 1); push(esi);                              /* push esi */
            ii(0x1019_4b75, 1); push(edi);                              /* push edi */
            ii(0x1019_4b76, 1); push(ebx);                              /* push ebx */
            ii(0x1019_4b77, 1); push(ecx);                              /* push ecx */
            ii(0x1019_4b78, 2); push(fs);                               /* push fs */
            ii(0x1019_4b7a, 2); push(gs);                               /* push gs */
            ii(0x1019_4b7c, 1); push(es);                               /* push es */
            ii(0x1019_4b7d, 7); cmp(memd[ds, 0x101c_1a54], 0);          /* cmp dword [0x101c1a54], 0x0 */
            ii(0x1019_4b84, 2); if(jz(0x1019_4b92, 0xc)) goto l_0x1019_4b92; /* jz 0x10194b92 */
            ii(0x1019_4b86, 1); nop();                                  /* nop */
            ii(0x1019_4b87, 1); nop();                                  /* nop */
            ii(0x1019_4b88, 1); nop();                                  /* nop */
            ii(0x1019_4b89, 1); nop();                                  /* nop */
            ii(0x1019_4b8a, 4); mov(dx, 0x21);                          /* mov dx, 0x21 */
            ii(0x1019_4b8e, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1019_4b8f, 2); and(al, 0xfe);                          /* and al, 0xfe */
            ii(0x1019_4b91, 1); outb(dx, al);                           /* out dx, al */
        l_0x1019_4b92:
            ii(0x1019_4b92, 1); pop(es);                                /* pop es */
            ii(0x1019_4b93, 2); pop(gs);                                /* pop gs */
            ii(0x1019_4b95, 2); pop(fs);                                /* pop fs */
            ii(0x1019_4b97, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_4b98, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_4b99, 1); pop(edi);                               /* pop edi */
            ii(0x1019_4b9a, 1); pop(esi);                               /* pop esi */
            ii(0x1019_4b9b, 1); pop(ebp);                               /* pop ebp */
            ii(0x1019_4b9c, 1); ret();                                  /* ret */
        }
    }
}
