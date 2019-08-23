using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_385f-a5b42d5f")]
        public void Method_1010_385f()
        {
            ii(0x1010_385f, 5); pushd(0x40);                            /* push 0x40 */
            ii(0x1010_3864, 5); calld(Definitions.sys_check_available_stack_size, 0x6_24e9); /* call 0x10165d52 */
            ii(0x1010_3869, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_386a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_386b, 1); pushd(esi);                             /* push esi */
            ii(0x1010_386c, 1); pushd(edi);                             /* push edi */
            ii(0x1010_386d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_386e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_3870, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x1010_3876, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_3879, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1010_387c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_387f, 5); calld(0x1010_380b, -0x79);              /* call 0x1010380b */
            ii(0x1010_3884, 5); mov(edx, 0x101b_63ec);                  /* mov edx, 0x101b63ec */
            ii(0x1010_3889, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_388c, 3); mov(eax, memd_a32[ds, eax + 0x4]);      /* mov eax, [eax+0x4] */
            ii(0x1010_388f, 5); calld(Definitions.sys_call_dtor_arr, 0x6_2724); /* call 0x10165fb8 */
            ii(0x1010_3894, 5); calld(Definitions.sys_delete_arr, 0x6_273f); /* call 0x10165fd8 */
            ii(0x1010_3899, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1010_389c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_389f, 5); calld(0x1013_bb7b, 0x3_82d7);           /* call 0x1013bb7b */
            ii(0x1010_38a4, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1010_38a7, 3); add(edx, 0x2);                          /* add edx, 0x2 */
            ii(0x1010_38aa, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_38ad, 5); calld(0x1013_bb7b, 0x3_82c9);           /* call 0x1013bb7b */
            ii(0x1010_38b2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_38b5, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1010_38b8, 4); mov(memw_a32[ss, ebp - 0x14], ax);      /* mov [ebp-0x14], ax */
            ii(0x1010_38bc, 5); mov(ebx, 0x101b_63ec);                  /* mov ebx, 0x101b63ec */
            ii(0x1010_38c1, 3); mov(edx, memd_a32[ss, ebp - 0x16]);     /* mov edx, [ebp-0x16] */
            ii(0x1010_38c4, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_38c7, 3); mov(eax, memd_a32[ss, ebp - 0x16]);     /* mov eax, [ebp-0x16] */
            ii(0x1010_38ca, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_38cd, 3); imul(eax, eax, 0xa);                    /* imul eax, eax, 0xa */
            ii(0x1010_38d0, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1010_38d3, 5); calld(Definitions.sys_new_arr, 0x6_2738); /* call 0x10166010 */
            ii(0x1010_38d8, 5); calld(Definitions.sys_call_ctor_arr, 0x6_e522); /* call 0x10171dff */
            ii(0x1010_38dd, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_38df, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_38e2, 3); mov(memd_a32[ds, eax + 0x4], edx);      /* mov [eax+0x4], edx */
            ii(0x1010_38e5, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1010_38ec, 2); jmpd(0x1010_38f4, 0x6); goto l_0x1010_38f4; /* jmp 0x101038f4 */
        l_0x1010_38ee:
            ii(0x1010_38ee, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_38f1, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x1010_38f4:
            ii(0x1010_38f4, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_38f7, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1010_38fa, 3); cmp(ax, memw_a32[ds, edx]);             /* cmp ax, [edx] */
            ii(0x1010_38fd, 6); if(jged(0x1010_397d, 0x7a)) goto l_0x1010_397d; /* jge 0x1010397d */
            ii(0x1010_3903, 3); lea(edx, ebp - 0x10);                   /* lea edx, [ebp-0x10] */
            ii(0x1010_3906, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_3909, 5); calld(0x1013_bb7b, 0x3_826d);           /* call 0x1013bb7b */
        l_0x1010_390e:
            ii(0x1010_390e, 3); dec(memd_a32[ss, ebp - 0x10]);          /* dec dword [ebp-0x10] */
            ii(0x1010_3911, 5); cmp(memw_a32[ss, ebp - 0x10], -0x1 /* 0xff */); /* cmp word [ebp-0x10], 0xffff */
            ii(0x1010_3916, 2); if(jzd(0x1010_3978, 0x60)) goto l_0x1010_3978; /* jz 0x10103978 */
            ii(0x1010_3918, 5); mov(eax, 0x14);                         /* mov eax, 0x14 */
            ii(0x1010_391d, 5); calld(Definitions.sys_new, 0x6_24de);   /* call 0x10165e00 */
            ii(0x1010_3922, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1010_3925, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1010_3928, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1010_392b, 4); cmp(memd_a32[ss, ebp - 0x1c], 0);       /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1010_392f, 2); if(jzd(0x1010_3948, 0x17)) goto l_0x1010_3948; /* jz 0x10103948 */
            ii(0x1010_3931, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_3933, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_3935, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1010_3938, 5); calld(0x1010_3069, -0x8d4);             /* call 0x10103069 */
            ii(0x1010_393d, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1010_3940, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1010_3943, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1010_3946, 2); jmpd(0x1010_394e, 0x6); goto l_0x1010_394e; /* jmp 0x1010394e */
        l_0x1010_3948:
            ii(0x1010_3948, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1010_394b, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
        l_0x1010_394e:
            ii(0x1010_394e, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1010_3951, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1010_3954, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1010_3957, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1010_395a, 5); calld(0x1010_30de, -0x881);             /* call 0x101030de */
            ii(0x1010_395f, 3); mov(edx, memd_a32[ss, ebp - 0x28]);     /* mov edx, [ebp-0x28] */
            ii(0x1010_3962, 4); movsx(ebx, memw_a32[ss, ebp - 0xc]);    /* movsx ebx, word [ebp-0xc] */
            ii(0x1010_3966, 3); imul(ebx, ebx, 0xa);                    /* imul ebx, ebx, 0xa */
            ii(0x1010_3969, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_396c, 3); mov(eax, memd_a32[ds, eax + 0x4]);      /* mov eax, [eax+0x4] */
            ii(0x1010_396f, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1010_3971, 5); calld(0x1010_4674, 0xcfe);              /* call 0x10104674 */
            ii(0x1010_3976, 2); jmpd(0x1010_390e, -0x6a); goto l_0x1010_390e; /* jmp 0x1010390e */
        l_0x1010_3978:
            ii(0x1010_3978, 5); jmpd(0x1010_38ee, -0x8f); goto l_0x1010_38ee; /* jmp 0x101038ee */
        l_0x1010_397d:
            ii(0x1010_397d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_397f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_3980, 1); popd(edi);                              /* pop edi */
            ii(0x1010_3981, 1); popd(esi);                              /* pop esi */
            ii(0x1010_3982, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_3983, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_3984, 1); retd();                                 /* ret */
        }
    }
}
