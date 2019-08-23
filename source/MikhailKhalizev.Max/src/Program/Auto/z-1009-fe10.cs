using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_fe10-24a8260f")]
        public void Method_1009_fe10()
        {
            ii(0x1009_fe10, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_fe15, 5); calld(Definitions.sys_check_available_stack_size, 0xc_5f38); /* call 0x10165d52 */
            ii(0x1009_fe1a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_fe1b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_fe1c, 1); pushd(esi);                             /* push esi */
            ii(0x1009_fe1d, 1); pushd(edi);                             /* push edi */
            ii(0x1009_fe1e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_fe1f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_fe21, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_fe27, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_fe2a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_fe2d, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x1009_fe34, 2); if(jzd(0x1009_fe4a, 0x14)) goto l_0x1009_fe4a; /* jz 0x1009fe4a */
            ii(0x1009_fe36, 5); mov(edx, 0x101b_4874);                  /* mov edx, 0x101b4874 */
            ii(0x1009_fe3b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_fe3e, 5); calld(Definitions.sys_call_dtor_arr, 0xc_6175); /* call 0x10165fb8 */
            ii(0x1009_fe43, 5); calld(Definitions.sys_delete_arr, 0xc_6190); /* call 0x10165fd8 */
            ii(0x1009_fe48, 2); jmpd(0x1009_fe7e, 0x34); goto l_0x1009_fe7e; /* jmp 0x1009fe7e */
        l_0x1009_fe4a:
            ii(0x1009_fe4a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_fe4c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_fe4f, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_fe52, 5); calld(0x1007_5f2c, -0x2_9f2b);          /* call 0x10075f2c */
            ii(0x1009_fe57, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x1009_fe5a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_fe5d, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1009_fe62, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_fe65, 5); calld(0x100a_284c, 0x29e2);             /* call 0x100a284c */
            ii(0x1009_fe6a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_fe6d, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x1009_fe74, 2); if(jzd(0x1009_fe7e, 0x8)) goto l_0x1009_fe7e; /* jz 0x1009fe7e */
            ii(0x1009_fe76, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_fe79, 5); calld(Definitions.sys_delete, 0xc_60e6); /* call 0x10165f64 */
        l_0x1009_fe7e:
            ii(0x1009_fe7e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_fe81, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_fe84, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_fe87, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_fe89, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_fe8a, 1); popd(edi);                              /* pop edi */
            ii(0x1009_fe8b, 1); popd(esi);                              /* pop esi */
            ii(0x1009_fe8c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_fe8d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_fe8e, 1); retd();                                 /* ret */
        }
    }
}
