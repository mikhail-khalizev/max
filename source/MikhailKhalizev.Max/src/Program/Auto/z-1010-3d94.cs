using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_3d94-ba40990b")]
        public void Method_1010_3d94()
        {
            ii(0x1010_3d94, 5); push(0x28);                             /* push 0x28 */
            ii(0x1010_3d99, 5); call(Definitions.sys_check_available_stack_size, 0x6_1fb4); /* call 0x10165d52 */
            ii(0x1010_3d9e, 1); push(ebx);                              /* push ebx */
            ii(0x1010_3d9f, 1); push(ecx);                              /* push ecx */
            ii(0x1010_3da0, 1); push(esi);                              /* push esi */
            ii(0x1010_3da1, 1); push(edi);                              /* push edi */
            ii(0x1010_3da2, 1); push(ebp);                              /* push ebp */
            ii(0x1010_3da3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_3da5, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1010_3dab, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_3dae, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1010_3db1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_3db4, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1010_3db7, 3); mov(memw[ds, edx], ax);                 /* mov [edx], ax */
            ii(0x1010_3dba, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_3dbd, 4); mov(memw[ss, ebp - 0xc], ax);           /* mov [ebp-0xc], ax */
            ii(0x1010_3dc1, 5); mov(ebx, 0x101b_56fc);                  /* mov ebx, 0x101b56fc */
            ii(0x1010_3dc6, 3); mov(edx, memd[ss, ebp - 0xe]);          /* mov edx, [ebp-0xe] */
            ii(0x1010_3dc9, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_3dcc, 3); mov(eax, memd[ss, ebp - 0xe]);          /* mov eax, [ebp-0xe] */
            ii(0x1010_3dcf, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_3dd2, 3); imul(eax, eax, 0xa);                    /* imul eax, eax, 0xa */
            ii(0x1010_3dd5, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1010_3dd8, 5); call(Definitions.sys_new_arr, 0x6_2233); /* call 0x10166010 */
            ii(0x1010_3ddd, 5); call(Definitions.sys_call_ctor_arr, 0x6_e01d); /* call 0x10171dff */
            ii(0x1010_3de2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_3de4, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_3de7, 3); mov(memd[ds, eax + 0x2], edx);          /* mov [eax+0x2], edx */
            ii(0x1010_3dea, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_3ded, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1010_3df0, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_3df3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_3df5, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_3df6, 1); pop(edi);                               /* pop edi */
            ii(0x1010_3df7, 1); pop(esi);                               /* pop esi */
            ii(0x1010_3df8, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_3df9, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_3dfa, 1); ret();                                  /* ret */
        }
    }
}
