using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_513e-bcd0f9d6")]
        public void /* sys */ Method_1019_513e()
        {
            ii(0x1019_513e, 1); push(ebp);                              /* push ebp */
            ii(0x1019_513f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_5141, 1); push(esi);                              /* push esi */
            ii(0x1019_5142, 1); push(edi);                              /* push edi */
            ii(0x1019_5143, 1); push(ebx);                              /* push ebx */
            ii(0x1019_5144, 1); push(ecx);                              /* push ecx */
            ii(0x1019_5145, 2); pushd(fs);                              /* push fs */
            ii(0x1019_5147, 2); pushd(gs);                              /* push gs */
            ii(0x1019_5149, 1); pushd(es);                              /* push es */
            ii(0x1019_514a, 4); mov(ax, 0x1600);                        /* mov ax, 0x1600 */
            ii(0x1019_514e, 2); @int(0x2f);                             /* int 0x2f */
            ii(0x1019_5150, 2); cmp(al, 0x3);                           /* cmp al, 0x3 */
            ii(0x1019_5152, 2); if(jnz(0x1019_5168, 0x14)) goto l_0x1019_5168; /* jnz 0x10195168 */
            ii(0x1019_5154, 1); nop();                                  /* nop */
            ii(0x1019_5155, 1); nop();                                  /* nop */
            ii(0x1019_5156, 1); nop();                                  /* nop */
            ii(0x1019_5157, 1); nop();                                  /* nop */
            ii(0x1019_5158, 2); mov(ah, 0x81);                          /* mov ah, 0x81 */
            ii(0x1019_515a, 2); mov(al, 0xb);                           /* mov al, 0xb */
            ii(0x1019_515c, 3); mov(ebx, memd[ss, ebp + 0x8]);          /* mov ebx, [ebp+0x8] */
            ii(0x1019_515f, 3); xor(dx, dx);                            /* xor dx, dx */
            ii(0x1019_5162, 2); @int(0x4b);                             /* int 0x4b */
            ii(0x1019_5164, 4); mov(ax, 0);                             /* mov ax, 0x0 */
        l_0x1019_5168:
            ii(0x1019_5168, 1); popd(es);                               /* pop es */
            ii(0x1019_5169, 2); popd(gs);                               /* pop gs */
            ii(0x1019_516b, 2); popd(fs);                               /* pop fs */
            ii(0x1019_516d, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_516e, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_516f, 1); pop(edi);                               /* pop edi */
            ii(0x1019_5170, 1); pop(esi);                               /* pop esi */
            ii(0x1019_5171, 1); pop(ebp);                               /* pop ebp */
            ii(0x1019_5172, 1); ret();                                  /* ret */
        }
    }
}
