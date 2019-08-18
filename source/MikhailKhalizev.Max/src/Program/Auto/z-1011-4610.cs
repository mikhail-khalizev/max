using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_4610-d5c125a")]
        public void Method_1011_4610()
        {
            ii(0x1011_4610, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1011_4615, 5); calld(Definitions.sys_check_available_stack_size, 0x5_1738); /* call 0x10165d52 */
            ii(0x1011_461a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_461b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_461c, 1); pushd(edx);                             /* push edx */
            ii(0x1011_461d, 1); pushd(esi);                             /* push esi */
            ii(0x1011_461e, 1); pushd(edi);                             /* push edi */
            ii(0x1011_461f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_4620, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_4622, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1011_4628, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_462b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_462e, 5); calld(0x1011_3b89, -0xaaa);             /* call 0x10113b89 */
            ii(0x1011_4633, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_4635, 5); calld(0x1010_94b1, -0xb189);            /* call 0x101094b1 */
            ii(0x1011_463a, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_463d, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
            ii(0x1011_4642, 5); calld(0x100c_aafc, -0x4_9b4b);          /* call 0x100caafc */
            ii(0x1011_4647, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
            ii(0x1011_464c, 5); calld(0x1007_5fdc, -0x9_e675);          /* call 0x10075fdc */
            ii(0x1011_4651, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_4654, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_4657, 5); calld(0x1011_4119, -0x543);             /* call 0x10114119 */
            ii(0x1011_465c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_465e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_4661, 5); calld(0x1011_3aca, -0xb9c);             /* call 0x10113aca */
            ii(0x1011_4666, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_4668, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_4669, 1); popd(edi);                              /* pop edi */
            ii(0x1011_466a, 1); popd(esi);                              /* pop esi */
            ii(0x1011_466b, 1); popd(edx);                              /* pop edx */
            ii(0x1011_466c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_466d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_466e, 1); retd(); return;                         /* ret */
        }
    }
}
