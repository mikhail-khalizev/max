using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9ff8ed8a-2032-4985-906e-090bd46ad262")]
        public void Method_100a_a3c0()
        {
            ii(0x100a_a3c0, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_a3c5, 5); calld(Definitions.sys_check_available_stack_size, 0xbb988); /* call 0x10165d52 */
            ii(0x100a_a3ca, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_a3cb, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_a3cc, 1); pushd(esi);                             /* push esi */
            ii(0x100a_a3cd, 1); pushd(edi);                             /* push edi */
            ii(0x100a_a3ce, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_a3cf, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_a3d1, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_a3d7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_a3da, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_a3dd, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x100a_a3e4, 2); if(jzd(0x100a_a3fa, 0x14)) goto l_0x100a_a3fa; /* jz 0x100aa3fa */
            ii(0x100a_a3e6, 5); mov(edx, 0x101b_4c90);                  /* mov edx, 0x101b4c90 */
            ii(0x100a_a3eb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_a3ee, 5); calld(Definitions.sys_call_dtor_arr, 0xbbbc5); /* call 0x10165fb8 */
            ii(0x100a_a3f3, 5); calld(Definitions.sys_delete_arr, 0xbbbe0); /* call 0x10165fd8 */
            ii(0x100a_a3f8, 2); jmpd(0x100a_a41b, 0x21); goto l_0x100a_a41b; /* jmp 0x100aa41b */
        l_0x100a_a3fa:
            ii(0x100a_a3fa, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100a_a3ff, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_a402, 5); calld(0x100c_d916, 0x2350f);            /* call 0x100cd916 */
            ii(0x100a_a407, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_a40a, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x100a_a411, 2); if(jzd(0x100a_a41b, 0x8)) goto l_0x100a_a41b; /* jz 0x100aa41b */
            ii(0x100a_a413, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_a416, 5); calld(Definitions.sys_delete, 0xbbb49); /* call 0x10165f64 */
        l_0x100a_a41b:
            ii(0x100a_a41b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_a41e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_a421, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_a424, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_a426, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_a427, 1); popd(edi);                              /* pop edi */
            ii(0x100a_a428, 1); popd(esi);                              /* pop esi */
            ii(0x100a_a429, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_a42a, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_a42b, 1); retd(); return;                         /* ret */
        }
    }
}
