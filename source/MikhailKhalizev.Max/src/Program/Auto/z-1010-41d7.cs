using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("82a18ae8-53d8-4b82-a18e-9bf183712caa")]
        public void Method_1010_41d7()
        {
            ii(0x1010_41d7, 5); pushd(0x44);                            /* push 0x44 */
            ii(0x1010_41dc, 5); calld(Definitions.sys_check_available_stack_size, 0x6_1b71); /* call 0x10165d52 */
            ii(0x1010_41e1, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_41e2, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_41e3, 1); pushd(esi);                             /* push esi */
            ii(0x1010_41e4, 1); pushd(edi);                             /* push edi */
            ii(0x1010_41e5, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_41e6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_41e8, 6); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x1010_41ee, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_41f1, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1010_41f4, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x1010_41f8, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1010_41fb, 5); calld(0x100e_0720, -0x2_3ae0);          /* call 0x100e0720 */
            ii(0x1010_4200, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1010_4203, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x1010_4207, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_420a, 5); calld(0x1010_3ff1, -0x21e);             /* call 0x10103ff1 */
            ii(0x1010_420f, 5); mov(edx, StringDefinitions.HashSize3);  /* mov edx, 0x101a32b6 */
            ii(0x1010_4214, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_4217, 5); calld(0x1014_60aa, 0x4_1e8e);           /* call 0x101460aa */
            ii(0x1010_421c, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_421f, 5); mov(ebx, 0x101b_56fc);                  /* mov ebx, 0x101b56fc */
            ii(0x1010_4224, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1010_4227, 3); mov(eax, memd_a32[ds, edx + 0x2]);      /* mov eax, [edx+0x2] */
            ii(0x1010_422a, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1010_422c, 5); calld(Definitions.sys_call_dtor_arr, 0x6_1d87); /* call 0x10165fb8 */
            ii(0x1010_4231, 5); calld(Definitions.sys_delete_arr, 0x6_1da2); /* call 0x10165fd8 */
            ii(0x1010_4236, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_4239, 4); mov(memw_a32[ss, ebp - 0x14], ax);      /* mov [ebp-0x14], ax */
            ii(0x1010_423d, 5); mov(ebx, 0x101b_56fc);                  /* mov ebx, 0x101b56fc */
            ii(0x1010_4242, 3); mov(edx, memd_a32[ss, ebp - 0x16]);     /* mov edx, [ebp-0x16] */
            ii(0x1010_4245, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_4248, 3); mov(eax, memd_a32[ss, ebp - 0x16]);     /* mov eax, [ebp-0x16] */
            ii(0x1010_424b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_424e, 3); imul(eax, eax, 0xa);                    /* imul eax, eax, 0xa */
            ii(0x1010_4251, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1010_4254, 5); calld(Definitions.sys_new_arr, 0x6_1db7); /* call 0x10166010 */
            ii(0x1010_4259, 5); calld(Definitions.sys_call_ctor_arr, 0x6_dba1); /* call 0x10171dff */
            ii(0x1010_425e, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1010_4261, 3); mov(memd_a32[ds, edx + 0x2], eax);      /* mov [edx+0x2], eax */
            ii(0x1010_4264, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_4267, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1010_426a, 3); mov(memw_a32[ds, edx], ax);             /* mov [edx], ax */
        l_0x1010_426d:
            ii(0x1010_426d, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_426f, 5); mov(ebx, StringDefinitions.List3);      /* mov ebx, 0x101a32c0 */
            ii(0x1010_4274, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x1010_4277, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_427a, 5); calld(0x1014_625c, 0x4_1fdd);           /* call 0x1014625c */
            ii(0x1010_427f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_4281, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1010_4284, 5); calld(0x100e_06a4, -0x2_3be5);          /* call 0x100e06a4 */
            ii(0x1010_4289, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x1010_428b, 5); calld(0x1013_ad71, 0x3_6ae1);           /* call 0x1013ad71 */
            ii(0x1010_4290, 2); test(al, al);                           /* test al, al */
            ii(0x1010_4292, 2); if(jzd(0x1010_429d, 0x9)) goto l_0x1010_429d; /* jz 0x1010429d */
            ii(0x1010_4294, 7); mov(memd_a32[ss, ebp - 0x28], 0x1);     /* mov dword [ebp-0x28], 0x1 */
            ii(0x1010_429b, 2); jmpd(0x1010_42a4, 0x7); goto l_0x1010_42a4; /* jmp 0x101042a4 */
        l_0x1010_429d:
            ii(0x1010_429d, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
        l_0x1010_42a4:
            ii(0x1010_42a4, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1010_42a7, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1010_42aa, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_42ac, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1010_42af, 5); calld(0x100e_03fc, -0x2_3eb8);          /* call 0x100e03fc */
            ii(0x1010_42b4, 4); cmp(memd_a32[ss, ebp - 0x2c], 0);       /* cmp dword [ebp-0x2c], 0x0 */
            ii(0x1010_42b8, 2); if(jzd(0x1010_42f2, 0x38)) goto l_0x1010_42f2; /* jz 0x101042f2 */
            ii(0x1010_42ba, 5); mov(edx, StringDefinitions.Index7);     /* mov edx, 0x101a32c5 */
            ii(0x1010_42bf, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1010_42c2, 5); calld(0x100e_0648, -0x2_3c7f);          /* call 0x100e0648 */
            ii(0x1010_42c7, 5); calld(0x1014_60aa, 0x4_1dde);           /* call 0x101460aa */
            ii(0x1010_42cc, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1010_42cf, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1010_42d2, 5); calld(0x1010_48c0, 0x5e9);              /* call 0x101048c0 */
            ii(0x1010_42d7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_42d9, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1010_42dd, 3); imul(ebx, eax, 0xa);                    /* imul ebx, eax, 0xa */
            ii(0x1010_42e0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_42e3, 3); mov(eax, memd_a32[ds, eax + 0x2]);      /* mov eax, [eax+0x2] */
            ii(0x1010_42e6, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1010_42e8, 5); calld(0x1010_2e9c, -0x1451);            /* call 0x10102e9c */
            ii(0x1010_42ed, 5); jmpd(0x1010_426d, -0x85); goto l_0x1010_426d; /* jmp 0x1010426d */
        l_0x1010_42f2:
            ii(0x1010_42f2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_42f4, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1010_42f7, 5); calld(0x100e_03fc, -0x2_3f00);          /* call 0x100e03fc */
            ii(0x1010_42fc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_42fe, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_42ff, 1); popd(edi);                              /* pop edi */
            ii(0x1010_4300, 1); popd(esi);                              /* pop esi */
            ii(0x1010_4301, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_4302, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_4303, 1); retd(); return;                         /* ret */
        }
    }
}
