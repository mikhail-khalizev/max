using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_01d8-5c76561c")]
        public void Method_100e_01d8()
        {
            ii(0x100e_01d8, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_01dd, 5); calld(Definitions.sys_check_available_stack_size, 0x8_5b70); /* call 0x10165d52 */
            ii(0x100e_01e2, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_01e3, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_01e4, 1); pushd(esi);                             /* push esi */
            ii(0x100e_01e5, 1); pushd(edi);                             /* push edi */
            ii(0x100e_01e6, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_01e7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_01e9, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_01ef, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_01f2, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_01f5, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x100e_01fc, 2); if(jzd(0x100e_0212, 0x14)) goto l_0x100e_0212; /* jz 0x100e0212 */
            ii(0x100e_01fe, 5); mov(edx, 0x101b_5dd8);                  /* mov edx, 0x101b5dd8 */
            ii(0x100e_0203, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_0206, 5); calld(Definitions.sys_call_dtor_arr, 0x8_5dad); /* call 0x10165fb8 */
            ii(0x100e_020b, 5); calld(Definitions.sys_delete_arr, 0x8_5dc8); /* call 0x10165fd8 */
            ii(0x100e_0210, 2); jmpd(0x100e_0233, 0x21); goto l_0x100e_0233; /* jmp 0x100e0233 */
        l_0x100e_0212:
            ii(0x100e_0212, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100e_0217, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_021a, 5); calld(0x100d_6e67, -0x93b8);            /* call 0x100d6e67 */
            ii(0x100e_021f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_0222, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x100e_0229, 2); if(jzd(0x100e_0233, 0x8)) goto l_0x100e_0233; /* jz 0x100e0233 */
            ii(0x100e_022b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_022e, 5); calld(Definitions.sys_delete, 0x8_5d31); /* call 0x10165f64 */
        l_0x100e_0233:
            ii(0x100e_0233, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_0236, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_0239, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_023c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_023e, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_023f, 1); popd(edi);                              /* pop edi */
            ii(0x100e_0240, 1); popd(esi);                              /* pop esi */
            ii(0x100e_0241, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_0242, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_0243, 1); retd(); return;                         /* ret */
        }
    }
}
