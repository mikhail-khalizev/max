using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1c128777-1982-4126-9d7d-0a1062f6c3d6")]
        public void Method_1010_43b0()
        {
            ii(0x1010_43b0, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1010_43b5, 5); calld(Definitions.sys_check_available_stack_size, 0x6_1998); /* call 0x10165d52 */
            ii(0x1010_43ba, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_43bb, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_43bc, 1); pushd(esi);                             /* push esi */
            ii(0x1010_43bd, 1); pushd(edi);                             /* push edi */
            ii(0x1010_43be, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_43bf, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_43c1, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1010_43c7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_43ca, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1010_43cd, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x1010_43d4, 2); if(jzd(0x1010_43ea, 0x14)) goto l_0x1010_43ea; /* jz 0x101043ea */
            ii(0x1010_43d6, 5); mov(edx, 0x101b_63c4);                  /* mov edx, 0x101b63c4 */
            ii(0x1010_43db, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_43de, 5); calld(Definitions.sys_call_dtor_arr, 0x6_1bd5); /* call 0x10165fb8 */
            ii(0x1010_43e3, 5); calld(Definitions.sys_delete_arr, 0x6_1bf0); /* call 0x10165fd8 */
            ii(0x1010_43e8, 2); jmpd(0x1010_441e, 0x34); goto l_0x1010_441e; /* jmp 0x1010441e */
        l_0x1010_43ea:
            ii(0x1010_43ea, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_43ec, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_43ef, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1010_43f2, 5); calld(Definitions.my_dtor_0x101b56fc, -0x7_b7bb); /* call 0x10088c3c */
            ii(0x1010_43f7, 3); sub(eax, 0x6);                          /* sub eax, 0x6 */
            ii(0x1010_43fa, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_43fd, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1010_4402, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_4405, 5); calld(0x1013_ab27, 0x3_671d);           /* call 0x1013ab27 */
            ii(0x1010_440a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_440d, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x1010_4414, 2); if(jzd(0x1010_441e, 0x8)) goto l_0x1010_441e; /* jz 0x1010441e */
            ii(0x1010_4416, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_4419, 5); calld(Definitions.sys_delete, 0x6_1b46); /* call 0x10165f64 */
        l_0x1010_441e:
            ii(0x1010_441e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_4421, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_4424, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_4427, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_4429, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_442a, 1); popd(edi);                              /* pop edi */
            ii(0x1010_442b, 1); popd(esi);                              /* pop esi */
            ii(0x1010_442c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_442d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_442e, 1); retd(); return;                         /* ret */
        }
    }
}
