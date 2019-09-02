using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_c388-2edec519")]
        public void Method_1013_c388()
        {
            ii(0x1013_c388, 5); push(0x28);                             /* push 0x28 */
            ii(0x1013_c38d, 5); call(Definitions.sys_check_available_stack_size, 0x2_99c0); /* call 0x10165d52 */
            ii(0x1013_c392, 1); push(ebx);                              /* push ebx */
            ii(0x1013_c393, 1); push(ecx);                              /* push ecx */
            ii(0x1013_c394, 1); push(esi);                              /* push esi */
            ii(0x1013_c395, 1); push(edi);                              /* push edi */
            ii(0x1013_c396, 1); push(ebp);                              /* push ebp */
            ii(0x1013_c397, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_c399, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1013_c39f, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_c3a2, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1013_c3a5, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1013_c3a8, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_c3ab, 5); call(0x1013_aae7, -0x18c9);             /* call 0x1013aae7 */
            ii(0x1013_c3b0, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_c3b3, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1013_c3b6, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1013_c3b9, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1013_c3bc, 3); add(edx, 6);                            /* add edx, 0x6 */
            ii(0x1013_c3bf, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_c3c2, 3); add(eax, 6);                            /* add eax, 0x6 */
            ii(0x1013_c3c5, 5); call(0x1013_c334, -0x96);               /* call 0x1013c334 */
            ii(0x1013_c3ca, 3); sub(eax, 6);                            /* sub eax, 0x6 */
            ii(0x1013_c3cd, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_c3d0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_c3d3, 3); mov(edx, memd[ds, eax + 0xe]);          /* mov edx, [eax+0xe] */
            ii(0x1013_c3d6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_c3d9, 3); mov(memd[ds, eax + 0xe], edx);          /* mov [eax+0xe], edx */
            ii(0x1013_c3dc, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_c3df, 3); mov(edx, memd[ds, eax + 0x12]);         /* mov edx, [eax+0x12] */
            ii(0x1013_c3e2, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_c3e5, 3); mov(memd[ds, eax + 0x12], edx);         /* mov [eax+0x12], edx */
            ii(0x1013_c3e8, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_c3eb, 7); mov(memd[ds, eax + 2], 0x101b_6f20);    /* mov dword [eax+0x2], 0x101b6f20 */
            ii(0x1013_c3f2, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_c3f5, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_c3f8, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_c3fb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_c3fd, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_c3fe, 1); pop(edi);                               /* pop edi */
            ii(0x1013_c3ff, 1); pop(esi);                               /* pop esi */
            ii(0x1013_c400, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_c401, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_c402, 1); ret();                                  /* ret */
        }
    }
}
