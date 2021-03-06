using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_509e-2be3ca79")]
        public void /* sys */ Method_1019_509e()
        {
            ii(0x1019_509e, 1);  push(ebp);                            /* push ebp */
            ii(0x1019_509f, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1019_50a1, 1);  push(esi);                            /* push esi */
            ii(0x1019_50a2, 1);  push(edi);                            /* push edi */
            ii(0x1019_50a3, 1);  push(ebx);                            /* push ebx */
            ii(0x1019_50a4, 1);  push(ecx);                            /* push ecx */
            ii(0x1019_50a5, 2);  pushd(fs);                            /* push fs */
            ii(0x1019_50a7, 2);  pushd(gs);                            /* push gs */
            ii(0x1019_50a9, 1);  pushd(es);                            /* push es */
            ii(0x1019_50aa, 4);  lfs(edi, memd[ss, ebp + 16]);         /* lfs edi, [ebp+0x10] */
            ii(0x1019_50ae, 5);  mov(eax, 4);                          /* mov eax, 0x4 */
            ii(0x1019_50b3, 3);  mov(ecx, memd[ss, ebp + 28]);         /* mov ecx, [ebp+0x1c] */
            ii(0x1019_50b6, 3);  mov(edi, memd[ss, ebp + 24]);         /* mov edi, [ebp+0x18] */
            ii(0x1019_50b9, 3);  call_far_ind(memd[ss, ebp + 8]);      /* call far dword [ebp+0x8] */
            ii(0x1019_50bc, 1);  popd(es);                             /* pop es */
            ii(0x1019_50bd, 2);  popd(gs);                             /* pop gs */
            ii(0x1019_50bf, 2);  popd(fs);                             /* pop fs */
            ii(0x1019_50c1, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1019_50c2, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1019_50c3, 1);  pop(edi);                             /* pop edi */
            ii(0x1019_50c4, 1);  pop(esi);                             /* pop esi */
            ii(0x1019_50c5, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1019_50c6, 1);  ret();                                /* ret */
        }
    }
}
