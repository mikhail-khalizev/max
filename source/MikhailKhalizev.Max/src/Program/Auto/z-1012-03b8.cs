using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("22febf43-cc37-41d9-bb68-75888d4fed72")]
        public void Method_1012_03b8()
        {
            ii(0x1012_03b8, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1012_03bd, 5); calld(Definitions.sys_check_available_stack_size, 0x4_5990); /* call 0x10165d52 */
            ii(0x1012_03c2, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_03c3, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_03c4, 1); pushd(esi);                             /* push esi */
            ii(0x1012_03c5, 1); pushd(edi);                             /* push edi */
            ii(0x1012_03c6, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_03c7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_03c9, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1012_03cf, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_03d2, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1012_03d5, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x1012_03dc, 2); if(jzd(0x1012_03f2, 0x14)) goto l_0x1012_03f2; /* jz 0x101203f2 */
            ii(0x1012_03de, 5); mov(edx, 0x101b_681c);                  /* mov edx, 0x101b681c */
            ii(0x1012_03e3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_03e6, 5); calld(Definitions.sys_call_dtor_arr, 0x4_5bcd); /* call 0x10165fb8 */
            ii(0x1012_03eb, 5); calld(Definitions.sys_delete_arr, 0x4_5be8); /* call 0x10165fd8 */
            ii(0x1012_03f0, 2); jmpd(0x1012_0413, 0x21); goto l_0x1012_0413; /* jmp 0x10120413 */
        l_0x1012_03f2:
            ii(0x1012_03f2, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1012_03f7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_03fa, 5); calld(0x1012_02cc, -0x133);             /* call 0x101202cc */
            ii(0x1012_03ff, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_0402, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x1012_0409, 2); if(jzd(0x1012_0413, 0x8)) goto l_0x1012_0413; /* jz 0x10120413 */
            ii(0x1012_040b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_040e, 5); calld(Definitions.sys_delete, 0x4_5b51); /* call 0x10165f64 */
        l_0x1012_0413:
            ii(0x1012_0413, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_0416, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1012_0419, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_041c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_041e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_041f, 1); popd(edi);                              /* pop edi */
            ii(0x1012_0420, 1); popd(esi);                              /* pop esi */
            ii(0x1012_0421, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_0422, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_0423, 1); retd(); return;                         /* ret */
        }
    }
}
