using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8a94dd37-f732-4eaf-ae4b-e3b5ba8cc06e")]
        public void Method_1009_ffd4()
        {
            ii(0x1009_ffd4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_ffd9, 5); calld(Definitions.sys_check_available_stack_size, 0xc_5d74); /* call 0x10165d52 */
            ii(0x1009_ffde, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_ffdf, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_ffe0, 1); pushd(esi);                             /* push esi */
            ii(0x1009_ffe1, 1); pushd(edi);                             /* push edi */
            ii(0x1009_ffe2, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_ffe3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_ffe5, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_ffeb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_ffee, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_fff1, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x1009_fff8, 2); if(jzd(0x100a_000e, 0x14)) goto l_0x100a_000e; /* jz 0x100a000e */
            ii(0x1009_fffa, 5); mov(edx, 0x101b_48c4);                  /* mov edx, 0x101b48c4 */
            ii(0x1009_ffff, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_0002, 5); calld(Definitions.sys_call_dtor_arr, 0xc_5fb1); /* call 0x10165fb8 */
            ii(0x100a_0007, 5); calld(Definitions.sys_delete_arr, 0xc_5fcc); /* call 0x10165fd8 */
            ii(0x100a_000c, 2); jmpd(0x100a_0042, 0x34); goto l_0x100a_0042; /* jmp 0x100a0042 */
        l_0x100a_000e:
            ii(0x100a_000e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_0010, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_0013, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100a_0016, 5); calld(0x1007_5f2c, -0x2_a0ef);          /* call 0x10075f2c */
            ii(0x100a_001b, 3); sub(eax, 0x17);                         /* sub eax, 0x17 */
            ii(0x100a_001e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_0021, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100a_0026, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_0029, 5); calld(0x100a_284c, 0x281e);             /* call 0x100a284c */
            ii(0x100a_002e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_0031, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x100a_0038, 2); if(jzd(0x100a_0042, 0x8)) goto l_0x100a_0042; /* jz 0x100a0042 */
            ii(0x100a_003a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_003d, 5); calld(Definitions.sys_delete, 0xc_5f22); /* call 0x10165f64 */
        l_0x100a_0042:
            ii(0x100a_0042, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_0045, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_0048, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_004b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_004d, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_004e, 1); popd(edi);                              /* pop edi */
            ii(0x100a_004f, 1); popd(esi);                              /* pop esi */
            ii(0x100a_0050, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_0051, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_0052, 1); retd(); return;                         /* ret */
        }
    }
}
