using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_4eeb-4c8b2ac")]
        public void /* sys */ Method_1019_4eeb()
        {
            ii(0x1019_4eeb, 1);  push(ebp);                            /* push ebp */
            ii(0x1019_4eec, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1019_4eee, 1);  push(esi);                            /* push esi */
            ii(0x1019_4eef, 1);  push(edi);                            /* push edi */
            ii(0x1019_4ef0, 1);  push(ebx);                            /* push ebx */
            ii(0x1019_4ef1, 1);  push(ecx);                            /* push ecx */
            ii(0x1019_4ef2, 2);  pushd(fs);                            /* push fs */
            ii(0x1019_4ef4, 2);  pushd(gs);                            /* push gs */
            ii(0x1019_4ef6, 1);  pushd(es);                            /* push es */
            ii(0x1019_4ef7, 5);  mov(eax, 5);                          /* mov eax, 0x5 */
            ii(0x1019_4efc, 4);  lfs(edi, memd[ss, ebp + 16]);         /* lfs edi, [ebp+0x10] */
            ii(0x1019_4f00, 3);  call_far_ind(memd[ss, ebp + 8]);      /* call far dword [ebp+0x8] */
            ii(0x1019_4f03, 1);  popd(es);                             /* pop es */
            ii(0x1019_4f04, 2);  popd(gs);                             /* pop gs */
            ii(0x1019_4f06, 2);  popd(fs);                             /* pop fs */
            ii(0x1019_4f08, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1019_4f09, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1019_4f0a, 1);  pop(edi);                             /* pop edi */
            ii(0x1019_4f0b, 1);  pop(esi);                             /* pop esi */
            ii(0x1019_4f0c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1019_4f0d, 1);  ret();                                /* ret */
        }
    }
}
