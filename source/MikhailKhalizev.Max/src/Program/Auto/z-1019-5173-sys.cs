using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_5173-80bc65f1")]
        public void /* sys */ Method_1019_5173()
        {
            ii(0x1019_5173, 1); push(ebp);                              /* push ebp */
            ii(0x1019_5174, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_5176, 1); push(esi);                              /* push esi */
            ii(0x1019_5177, 1); push(edi);                              /* push edi */
            ii(0x1019_5178, 1); push(ebx);                              /* push ebx */
            ii(0x1019_5179, 1); push(ecx);                              /* push ecx */
            ii(0x1019_517a, 2); pushd(fs);                              /* push fs */
            ii(0x1019_517c, 2); pushd(gs);                              /* push gs */
            ii(0x1019_517e, 1); pushd(es);                              /* push es */
            ii(0x1019_517f, 4); mov(ax, 0x1600);                        /* mov ax, 0x1600 */
            ii(0x1019_5183, 2); @int(0x2f);                             /* int 0x2f */
            ii(0x1019_5185, 2); cmp(al, 3);                             /* cmp al, 0x3 */
            ii(0x1019_5187, 2); if(jnz(0x1019_519d, 0x14)) goto l_0x1019_519d; /* jnz 0x1019519d */
            ii(0x1019_5189, 1); nop();                                  /* nop */
            ii(0x1019_518a, 1); nop();                                  /* nop */
            ii(0x1019_518b, 1); nop();                                  /* nop */
            ii(0x1019_518c, 1); nop();                                  /* nop */
            ii(0x1019_518d, 2); mov(ah, 0x81);                          /* mov ah, 0x81 */
            ii(0x1019_518f, 2); mov(al, 0xc);                           /* mov al, 0xc */
            ii(0x1019_5191, 3); mov(ebx, memd[ss, ebp + 8]);            /* mov ebx, [ebp+0x8] */
            ii(0x1019_5194, 3); xor(dx, dx);                            /* xor dx, dx */
            ii(0x1019_5197, 2); @int(0x4b);                             /* int 0x4b */
            ii(0x1019_5199, 4); mov(ax, 0);                             /* mov ax, 0x0 */
        l_0x1019_519d:
            ii(0x1019_519d, 1); popd(es);                               /* pop es */
            ii(0x1019_519e, 2); popd(gs);                               /* pop gs */
            ii(0x1019_51a0, 2); popd(fs);                               /* pop fs */
            ii(0x1019_51a2, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_51a3, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_51a4, 1); pop(edi);                               /* pop edi */
            ii(0x1019_51a5, 1); pop(esi);                               /* pop esi */
            ii(0x1019_51a6, 1); pop(ebp);                               /* pop ebp */
            ii(0x1019_51a7, 1); ret();                                  /* ret */
        }
    }
}
