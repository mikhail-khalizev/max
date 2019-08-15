using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5aa91d4e-010a-4ddc-8d4b-b86f38628bc5")]
        public void Method_1012_accb()
        {
            ii(0x1012_accb, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1012_acd0, 5); calld(Definitions.sys_check_available_stack_size, 0x3_b07d); /* call 0x10165d52 */
            ii(0x1012_acd5, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_acd6, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_acd7, 1); pushd(edx);                             /* push edx */
            ii(0x1012_acd8, 1); pushd(esi);                             /* push esi */
            ii(0x1012_acd9, 1); pushd(edi);                             /* push edi */
            ii(0x1012_acda, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_acdb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_acdd, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1012_ace3, 7); mov(memb_a32[ds, 0x101c_5c1c], 0x22);   /* mov byte [0x101c5c1c], 0x22 */
            ii(0x1012_acea, 6); mov(ebx, memd_a32[ds, 0x101c_59cc]);    /* mov ebx, [0x101c59cc] */
            ii(0x1012_acf0, 4); mov(ax, memw_a32[ds, ebx + 0xc]);       /* mov ax, [ebx+0xc] */
            ii(0x1012_acf4, 6); mov(memw_a32[ds, 0x101c_5c1d], ax);     /* mov [0x101c5c1d], ax */
            ii(0x1012_acfa, 9); mov(memw_a32[ds, 0x101c_5c1f], 0x18);   /* mov word [0x101c5c1f], 0x18 */
            ii(0x1012_ad03, 7); mov(memd_a32[ss, ebp - 0x4], 0x101c_5c21); /* mov dword [ebp-0x4], 0x101c5c21 */
            ii(0x1012_ad0a, 5); mov(ebx, 0x18);                         /* mov ebx, 0x18 */
            ii(0x1012_ad0f, 5); mov(edx, 0x101c_4090);                  /* mov edx, 0x101c4090 */
            ii(0x1012_ad14, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_ad17, 5); calld(Definitions.sys_memcpy, 0x3_b12f); /* call 0x10165e4b */
            ii(0x1012_ad1c, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x1012_ad21, 5); calld(0x1012_5be9, -0x513d);            /* call 0x10125be9 */
            ii(0x1012_ad26, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_ad28, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_ad29, 1); popd(edi);                              /* pop edi */
            ii(0x1012_ad2a, 1); popd(esi);                              /* pop esi */
            ii(0x1012_ad2b, 1); popd(edx);                              /* pop edx */
            ii(0x1012_ad2c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_ad2d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_ad2e, 1); retd(); return;                         /* ret */
        }
    }
}
