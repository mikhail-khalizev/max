using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_ccfc-37809fe4")]
        public void Method_1019_ccfc()
        {
            ii(0x1019_ccfc, 1); push(edi);                              /* push edi */
            ii(0x1019_ccfd, 1); push(ecx);                              /* push ecx */
            ii(0x1019_ccfe, 5); call(0x1019_ce0b, 0x108);               /* call 0x1019ce0b */
            ii(0x1019_cd03, 1); inc(eax);                               /* inc eax */
            ii(0x1019_cd04, 3); lea(edi, memd[ds, edi + eax * 8]);      /* lea edi, [edi+eax*8] */
            ii(0x1019_cd07, 2); mov(ecx, memd[ds, edx]);                /* mov ecx, [edx] */
            ii(0x1019_cd09, 3); mov(edx, memd[ds, edx + 0x4]);          /* mov edx, [edx+0x4] */
            ii(0x1019_cd0c, 2); sub(eax, eax);                          /* sub eax, eax */
        l_0x1019_cd0e:
            ii(0x1019_cd0e, 3); cmp(edx, memd[cs, edi]);                /* cmp edx, [cs:edi] */
            ii(0x1019_cd11, 2); if(jnz(0x1019_cd17, 0x4)) goto l_0x1019_cd17; /* jnz 0x1019cd17 */
            ii(0x1019_cd13, 4); cmp(ecx, memd[cs, edi + 0x4]);          /* cmp ecx, [cs:edi+0x4] */
        l_0x1019_cd17:
            ii(0x1019_cd17, 2); if(jb(0x1019_cd1f, 0x6)) goto l_0x1019_cd1f; /* jb 0x1019cd1f */
            ii(0x1019_cd19, 3); add(edi, 0x8);                          /* add edi, 0x8 */
            ii(0x1019_cd1c, 1); inc(eax);                               /* inc eax */
            ii(0x1019_cd1d, 2); jmp(0x1019_cd0e, -0x11); goto l_0x1019_cd0e; /* jmp 0x1019cd0e */
        l_0x1019_cd1f:
            ii(0x1019_cd1f, 3); sub(edi, 0x8);                          /* sub edi, 0x8 */
        l_0x1019_cd22:
            ii(0x1019_cd22, 3); cmp(edx, memd[cs, edi]);                /* cmp edx, [cs:edi] */
            ii(0x1019_cd25, 2); if(jnz(0x1019_cd2b, 0x4)) goto l_0x1019_cd2b; /* jnz 0x1019cd2b */
            ii(0x1019_cd27, 4); cmp(ecx, memd[cs, edi + 0x4]);          /* cmp ecx, [cs:edi+0x4] */
        l_0x1019_cd2b:
            ii(0x1019_cd2b, 2); if(jae(0x1019_cd33, 0x6)) goto l_0x1019_cd33; /* jae 0x1019cd33 */
            ii(0x1019_cd2d, 3); sub(edi, 0x8);                          /* sub edi, 0x8 */
            ii(0x1019_cd30, 1); dec(eax);                               /* dec eax */
            ii(0x1019_cd31, 2); jmp(0x1019_cd22, -0x11); goto l_0x1019_cd22; /* jmp 0x1019cd22 */
        l_0x1019_cd33:
            ii(0x1019_cd33, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_cd34, 1); pop(edi);                               /* pop edi */
            ii(0x1019_cd35, 1); ret();                                  /* ret */
        }
    }
}
