using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8ebde7b0-7c20-44c3-968d-8b526121c4b7")]
        public void Method_100d_4e00()
        {
            ii(0x100d_4e00, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100d_4e05, 5); calld(Definitions.sys_check_available_stack_size, 0x9_0f48); /* call 0x10165d52 */
            ii(0x100d_4e0a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_4e0b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_4e0c, 1); pushd(esi);                             /* push esi */
            ii(0x100d_4e0d, 1); pushd(edi);                             /* push edi */
            ii(0x100d_4e0e, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_4e0f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_4e11, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100d_4e17, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_4e1a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_4e1d, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x100d_4e24, 2); if(jzd(0x100d_4e3a, 0x14)) goto l_0x100d_4e3a; /* jz 0x100d4e3a */
            ii(0x100d_4e26, 5); mov(edx, 0x101b_5be8);                  /* mov edx, 0x101b5be8 */
            ii(0x100d_4e2b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_4e2e, 5); calld(Definitions.sys_call_dtor_arr, 0x9_1185); /* call 0x10165fb8 */
            ii(0x100d_4e33, 5); calld(Definitions.sys_delete_arr, 0x9_11a0); /* call 0x10165fd8 */
            ii(0x100d_4e38, 2); jmpd(0x100d_4e5b, 0x21); goto l_0x100d_4e5b; /* jmp 0x100d4e5b */
        l_0x100d_4e3a:
            ii(0x100d_4e3a, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100d_4e3f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_4e42, 5); calld(0x100d_10b2, -0x3d95);            /* call 0x100d10b2 */
            ii(0x100d_4e47, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_4e4a, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x100d_4e51, 2); if(jzd(0x100d_4e5b, 0x8)) goto l_0x100d_4e5b; /* jz 0x100d4e5b */
            ii(0x100d_4e53, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_4e56, 5); calld(Definitions.sys_delete, 0x9_1109); /* call 0x10165f64 */
        l_0x100d_4e5b:
            ii(0x100d_4e5b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_4e5e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100d_4e61, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100d_4e64, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_4e66, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_4e67, 1); popd(edi);                              /* pop edi */
            ii(0x100d_4e68, 1); popd(esi);                              /* pop esi */
            ii(0x100d_4e69, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_4e6a, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_4e6b, 1); retd(); return;                         /* ret */
        }
    }
}
