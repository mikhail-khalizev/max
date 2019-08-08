using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1e89a476-072e-4dc7-84b2-046ff662b241")]
        public void my_string_ctor_char_ptr()
        {
            ii(0x1014_1a3b, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1014_1a40, 5); calld(Definitions.sys_check_available_stack_size, 0x2_430d); /* call 0x10165d52 */
            ii(0x1014_1a45, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_1a46, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_1a47, 1); pushd(esi);                             /* push esi */
            ii(0x1014_1a48, 1); pushd(edi);                             /* push edi */
            ii(0x1014_1a49, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_1a4a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_1a4c, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1014_1a52, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_1a55, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_1a58, 5); mov(eax, 0xc);                          /* mov eax, 0xc */
            ii(0x1014_1a5d, 5); calld(Definitions.sys_new, 0x2_439e);   /* call 0x10165e00 */
            ii(0x1014_1a62, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_1a65, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_1a68, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1014_1a6b, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1014_1a6f, 2); if(jzd(0x1014_1a87, 0x16)) goto l_0x1014_1a87; /* jz 0x10141a87 */
            ii(0x1014_1a71, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_1a74, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_1a77, 5); calld(Definitions.my_strobj_ctor_char_ptr, -0x2e0); /* call 0x1014179c */
            ii(0x1014_1a7c, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1014_1a7f, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1014_1a82, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_1a85, 2); jmpd(0x1014_1a8d, 0x6); goto l_0x1014_1a8d; /* jmp 0x10141a8d */
        l_0x1014_1a87:
            ii(0x1014_1a87, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1014_1a8a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
        l_0x1014_1a8d:
            ii(0x1014_1a8d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_1a90, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_1a93, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
            ii(0x1014_1a95, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_1a98, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1014_1a9b, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1014_1a9e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_1aa0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_1aa1, 1); popd(edi);                              /* pop edi */
            ii(0x1014_1aa2, 1); popd(esi);                              /* pop esi */
            ii(0x1014_1aa3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_1aa4, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_1aa5, 1); retd(); return;                         /* ret */
        }
    }
}
