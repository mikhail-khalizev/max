using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f55073ad-c49f-4573-a89d-3b3e6fcaa270")]
        public void Method_1012_b31a()
        {
            ii(0x1012_b31a, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1012_b31f, 5); calld(Definitions.sys_check_available_stack_size, 0x3aa2e); /* call 0x10165d52 */
            ii(0x1012_b324, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_b325, 1); pushd(esi);                             /* push esi */
            ii(0x1012_b326, 1); pushd(edi);                             /* push edi */
            ii(0x1012_b327, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_b328, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_b32a, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1012_b330, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_b333, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x1012_b336, 3); mov(memd_a32[ss, ebp - 0xc], ebx);      /* mov [ebp-0xc], ebx */
            ii(0x1012_b339, 7); mov(memb_a32[ds, 0x101c_5c1c], 0x2e);   /* mov byte [0x101c5c1c], 0x2e */
            ii(0x1012_b340, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_b343, 6); mov(memw_a32[ds, 0x101c_5c1d], ax);     /* mov [0x101c5c1d], ax */
            ii(0x1012_b349, 9); mov(memw_a32[ds, 0x101c_5c1f], 0x5);    /* mov word [0x101c5c1f], 0x5 */
            ii(0x1012_b352, 7); mov(memd_a32[ss, ebp - 0x10], 0x101c_5c21); /* mov dword [ebp-0x10], 0x101c5c21 */
            ii(0x1012_b359, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1012_b35c, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1012_b35f, 2); mov(memb_a32[ds, edx], al);             /* mov [edx], al */
            ii(0x1012_b361, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_b364, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1012_b367, 3); mov(memd_a32[ds, edx + 0x1], eax);      /* mov [edx+0x1], eax */
            ii(0x1012_b36a, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x1012_b36f, 5); calld(0x1012_5be9, -0x578b);            /* call 0x10125be9 */
            ii(0x1012_b374, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_b376, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_b377, 1); popd(edi);                              /* pop edi */
            ii(0x1012_b378, 1); popd(esi);                              /* pop esi */
            ii(0x1012_b379, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_b37a, 1); retd(); return;                         /* ret */
        }
    }
}