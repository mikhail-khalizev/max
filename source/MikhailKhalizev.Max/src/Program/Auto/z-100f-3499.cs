using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("30865c93-897f-43c9-9fa3-c114e5338821")]
        public void Method_100f_3499()
        {
            ii(0x100f_3499, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100f_349e, 5); calld(Definitions.sys_check_available_stack_size, 0x728af); /* call 0x10165d52 */
            ii(0x100f_34a3, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_34a4, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_34a5, 1); pushd(edx);                             /* push edx */
            ii(0x100f_34a6, 1); pushd(esi);                             /* push esi */
            ii(0x100f_34a7, 1); pushd(edi);                             /* push edi */
            ii(0x100f_34a8, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_34a9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_34ab, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100f_34b1, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100f_34b4, 5); mov(eax, 0x300);                        /* mov eax, 0x300 */
            ii(0x100f_34b9, 5); calld(Definitions.sys_malloc, 0x77b20); /* call 0x1016afde */
            ii(0x100f_34be, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100f_34c1, 5); mov(ebx, 0x300);                        /* mov ebx, 0x300 */
            ii(0x100f_34c6, 6); mov(edx, memd_a32[ds, Definitions.ptr_to_pallete]); /* mov edx, [0x101c9464] */
            ii(0x100f_34cc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_34cf, 5); calld(Definitions.sys_memcpy, 0x72977); /* call 0x10165e4b */
            ii(0x100f_34d4, 5); calld(0x100f_2955, -0xb84);             /* call 0x100f2955 */
            ii(0x100f_34d9, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_34dd, 5); calld(0x100e_93d0, -0xa112);            /* call 0x100e93d0 */
            ii(0x100f_34e2, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100f_34e7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_34e9, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_34eb, 5); calld(0x100f_fca3, 0xc7b3);             /* call 0x100ffca3 */
            ii(0x100f_34f0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_34f3, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100f_34f6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_34f9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_34fb, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_34fc, 1); popd(edi);                              /* pop edi */
            ii(0x100f_34fd, 1); popd(esi);                              /* pop esi */
            ii(0x100f_34fe, 1); popd(edx);                              /* pop edx */
            ii(0x100f_34ff, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_3500, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_3501, 1); retd(); return;                         /* ret */
        }
    }
}
