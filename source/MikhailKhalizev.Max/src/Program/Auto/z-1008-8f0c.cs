using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_8f0c-97e48999")]
        public void Method_1008_8f0c()
        {
            ii(0x1008_8f0c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_8f11, 5); calld(Definitions.sys_check_available_stack_size, 0xd_ce3c); /* call 0x10165d52 */
            ii(0x1008_8f16, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_8f17, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_8f18, 1); pushd(esi);                             /* push esi */
            ii(0x1008_8f19, 1); pushd(edi);                             /* push edi */
            ii(0x1008_8f1a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_8f1b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_8f1d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_8f23, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_8f26, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_8f29, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x1008_8f30, 2); if(jzd(0x1008_8f46, 0x14)) goto l_0x1008_8f46; /* jz 0x10088f46 */
            ii(0x1008_8f32, 5); mov(edx, 0x101b_39c8);                  /* mov edx, 0x101b39c8 */
            ii(0x1008_8f37, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_8f3a, 5); calld(Definitions.sys_call_dtor_arr, 0xd_d079); /* call 0x10165fb8 */
            ii(0x1008_8f3f, 5); calld(Definitions.sys_delete_arr, 0xd_d094); /* call 0x10165fd8 */
            ii(0x1008_8f44, 2); jmpd(0x1008_8fb3, 0x6d); goto l_0x1008_8fb3; /* jmp 0x10088fb3 */
        l_0x1008_8f46:
            ii(0x1008_8f46, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_8f48, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_8f4b, 3); add(eax, 0x2d);                         /* add eax, 0x2d */
            ii(0x1008_8f4e, 5); calld(0x1008_8dcc, -0x187);             /* call 0x10088dcc */
            ii(0x1008_8f53, 3); sub(eax, 0x2d);                         /* sub eax, 0x2d */
            ii(0x1008_8f56, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_8f59, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_8f5b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_8f5e, 3); add(eax, 0x29);                         /* add eax, 0x29 */
            ii(0x1008_8f61, 5); calld(0x1007_5f2c, -0x1_303a);          /* call 0x10075f2c */
            ii(0x1008_8f66, 3); sub(eax, 0x29);                         /* sub eax, 0x29 */
            ii(0x1008_8f69, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_8f6c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_8f6e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_8f71, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x1008_8f74, 5); calld(Definitions.my_dtor_0x101b_56fc, -0x33d); /* call 0x10088c3c */
            ii(0x1008_8f79, 3); sub(eax, 0x19);                         /* sub eax, 0x19 */
            ii(0x1008_8f7c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_8f7f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_8f81, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_8f84, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_8f87, 5); calld(0x1008_8e0c, -0x180);             /* call 0x10088e0c */
            ii(0x1008_8f8c, 3); sub(eax, 0x15);                         /* sub eax, 0x15 */
            ii(0x1008_8f8f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_8f92, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1008_8f97, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_8f9a, 5); calld(0x100a_284c, 0x1_98ad);           /* call 0x100a284c */
            ii(0x1008_8f9f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_8fa2, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x1008_8fa9, 2); if(jzd(0x1008_8fb3, 0x8)) goto l_0x1008_8fb3; /* jz 0x10088fb3 */
            ii(0x1008_8fab, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_8fae, 5); calld(Definitions.sys_delete, 0xd_cfb1); /* call 0x10165f64 */
        l_0x1008_8fb3:
            ii(0x1008_8fb3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_8fb6, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_8fb9, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_8fbc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_8fbe, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_8fbf, 1); popd(edi);                              /* pop edi */
            ii(0x1008_8fc0, 1); popd(esi);                              /* pop esi */
            ii(0x1008_8fc1, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_8fc2, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_8fc3, 1); retd();                                 /* ret */
        }
    }
}
