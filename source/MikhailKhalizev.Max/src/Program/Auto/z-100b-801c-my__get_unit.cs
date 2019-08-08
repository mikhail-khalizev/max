using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d9d546e7-2d33-40d1-9511-d082a055408d")]
        public void my__get_unit()
        {
            ii(0x100b_801c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_8021, 5); calld(Definitions.sys_check_available_stack_size, 0xa_dd2c); /* call 0x10165d52 */
            ii(0x100b_8026, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_8027, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_8028, 1); pushd(edx);                             /* push edx */
            ii(0x100b_8029, 1); pushd(esi);                             /* push esi */
            ii(0x100b_802a, 1); pushd(edi);                             /* push edi */
            ii(0x100b_802b, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_802c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_802e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_8034, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_8037, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_803a, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100b_803d, 5); calld(0x1007_65d0, -0x4_1a72);          /* call 0x100765d0 */
            ii(0x100b_8042, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_8045, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_8048, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_804a, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_804b, 1); popd(edi);                              /* pop edi */
            ii(0x100b_804c, 1); popd(esi);                              /* pop esi */
            ii(0x100b_804d, 1); popd(edx);                              /* pop edx */
            ii(0x100b_804e, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_804f, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_8050, 1); retd(); return;                         /* ret */
        }
    }
}
