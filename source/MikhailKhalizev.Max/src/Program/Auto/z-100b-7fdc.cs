using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_7fdc-52171efd")]
        public void Method_100b_7fdc()
        {
            ii(0x100b_7fdc, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100b_7fe1, 5); calld(Definitions.sys_check_available_stack_size, 0xa_dd6c); /* call 0x10165d52 */
            ii(0x100b_7fe6, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_7fe7, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_7fe8, 1); pushd(edx);                             /* push edx */
            ii(0x100b_7fe9, 1); pushd(esi);                             /* push esi */
            ii(0x100b_7fea, 1); pushd(edi);                             /* push edi */
            ii(0x100b_7feb, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_7fec, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_7fee, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_7ff4, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_7ff7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_7ffa, 5); calld(Definitions.my_ctor_0x101b_6edc, -0x4_11bb); /* call 0x10076e44 */
            ii(0x100b_7fff, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_8002, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100b_8005, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_8008, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_800b, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_800e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_8011, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_8013, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_8014, 1); popd(edi);                              /* pop edi */
            ii(0x100b_8015, 1); popd(esi);                              /* pop esi */
            ii(0x100b_8016, 1); popd(edx);                              /* pop edx */
            ii(0x100b_8017, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_8018, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_8019, 1); retd(); return;                         /* ret */
        }
    }
}
