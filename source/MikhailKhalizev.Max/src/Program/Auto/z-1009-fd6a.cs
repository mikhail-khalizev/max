using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_fd6a-5de109d3")]
        public void Method_1009_fd6a()
        {
            ii(0x1009_fd6a, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1009_fd6f, 5); calld(Definitions.sys_check_available_stack_size, 0xc_5fde); /* call 0x10165d52 */
            ii(0x1009_fd74, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_fd75, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_fd76, 1); pushd(esi);                             /* push esi */
            ii(0x1009_fd77, 1); pushd(edi);                             /* push edi */
            ii(0x1009_fd78, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_fd79, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_fd7b, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_fd81, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_fd84, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_fd87, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_fd8a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_fd8d, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_fd90, 5); calld(0x1007_6e00, -0x2_8f95);          /* call 0x10076e00 */
            ii(0x1009_fd95, 2); test(al, al);                           /* test al, al */
            ii(0x1009_fd97, 2); if(jzd(0x1009_fdb3, 0x1a)) goto l_0x1009_fdb3; /* jz 0x1009fdb3 */
            ii(0x1009_fd99, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_fd9b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_fd9e, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_fda1, 5); calld(0x1007_6630, -0x2_9776);          /* call 0x10076630 */
            ii(0x1009_fda6, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_fda9, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_fdae, 5); calld(0x100a_5e27, 0x6074);             /* call 0x100a5e27 */
        l_0x1009_fdb3:
            ii(0x1009_fdb3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_fdb5, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_fdb6, 1); popd(edi);                              /* pop edi */
            ii(0x1009_fdb7, 1); popd(esi);                              /* pop esi */
            ii(0x1009_fdb8, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_fdb9, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_fdba, 1); retd(); return;                         /* ret */
        }
    }
}
