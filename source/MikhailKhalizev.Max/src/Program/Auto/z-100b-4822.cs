using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_4822-d2610748")]
        public void Method_100b_4822()
        {
            ii(0x100b_4822, 5); push(0x70);                             /* push 0x70 */
            ii(0x100b_4827, 5); call(Definitions.sys_check_available_stack_size, 0xb_1526); /* call 0x10165d52 */
            ii(0x100b_482c, 1); push(esi);                              /* push esi */
            ii(0x100b_482d, 1); push(edi);                              /* push edi */
            ii(0x100b_482e, 1); push(ebp);                              /* push ebp */
            ii(0x100b_482f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_4831, 6); sub(esp, 0x5c);                         /* sub esp, 0x5c */
            ii(0x100b_4837, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x100b_483a, 3); mov(memd[ss, ebp - 12], edx);           /* mov [ebp-0xc], edx */
            ii(0x100b_483d, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x100b_4840, 3); mov(memb[ss, ebp - 4], cl);             /* mov [ebp-0x4], cl */
            ii(0x100b_4843, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x100b_4846, 5); call(Definitions.my_ctor_0x101b_4184, -0x3_dd5b); /* call 0x10076af0 */
            ii(0x100b_484b, 4); mov(memb[ss, ebp - 24], 0);             /* mov byte [ebp-0x18], 0x0 */
            ii(0x100b_484f, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100b_4852, 3); mov(ebx, memd[ds, eax + 26]);           /* mov ebx, [eax+0x1a] */
            ii(0x100b_4855, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100b_4858, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100b_485b, 3); mov(edx, memd[ds, eax + 24]);           /* mov edx, [eax+0x18] */
            ii(0x100b_485e, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_4861, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x100b_4864, 5); call(0x1007_6aac, -0x3_ddbd);           /* call 0x10076aac */
            ii(0x100b_4869, 4); or(memb[ss, ebp - 32], 1);              /* or byte [ebp-0x20], 0x1 */
            ii(0x100b_486d, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100b_4870, 4); test(memb[ds, eax + 19], 1);            /* test byte [eax+0x13], 0x1 */
            ii(0x100b_4874, 2); if(jz(0x100b_487f, 9)) goto l_0x100b_487f; /* jz 0x100b487f */
            ii(0x100b_4876, 7); mov(memd[ss, ebp - 36], 0x4e);          /* mov dword [ebp-0x24], 0x4e */
            ii(0x100b_487d, 2); jmp(0x100b_4886, 7); goto l_0x100b_4886; /* jmp 0x100b4886 */
        l_0x100b_487f:
            ii(0x100b_487f, 7); mov(memd[ss, ebp - 36], 0xffff_ffff);   /* mov dword [ebp-0x24], 0xffffffff */
        l_0x100b_4886:
            ii(0x100b_4886, 3); mov(eax, memd[ss, ebp - 38]);           /* mov eax, [ebp-0x26] */
            ii(0x100b_4889, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_488c, 1); push(eax);                              /* push eax */
            ii(0x100b_488d, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100b_488f, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x100b_4894, 3); mov(edx, memd[ss, ebp - 16]);           /* mov edx, [ebp-0x10] */
            ii(0x100b_4897, 3); lea(eax, memd[ss, ebp - 52]);           /* lea eax, [ebp-0x34] */
            ii(0x100b_489a, 5); call(0x1011_fec1, 0x6_b622);            /* call 0x1011fec1 */
            ii(0x100b_489f, 3); mov(memd[ss, ebp - 56], eax);           /* mov [ebp-0x38], eax */
            ii(0x100b_48a2, 4); and(memb[ss, ebp - 32], -2 /* 0xfe */); /* and byte [ebp-0x20], 0xfe */
            ii(0x100b_48a6, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100b_48a9, 4); test(memb[ds, eax + 18], 0x10);         /* test byte [eax+0x12], 0x10 */
            ii(0x100b_48ad, 2); if(jz(0x100b_48b8, 9)) goto l_0x100b_48b8; /* jz 0x100b48b8 */
            ii(0x100b_48af, 7); mov(memd[ss, ebp - 60], 3);             /* mov dword [ebp-0x3c], 0x3 */
            ii(0x100b_48b6, 2); jmp(0x100b_48bf, 7); goto l_0x100b_48bf; /* jmp 0x100b48bf */
        l_0x100b_48b8:
            ii(0x100b_48b8, 7); mov(memd[ss, ebp - 60], 2);             /* mov dword [ebp-0x3c], 0x2 */
        l_0x100b_48bf:
            ii(0x100b_48bf, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100b_48c2, 4); mov(ax, memw[ds, eax + 26]);            /* mov ax, [eax+0x1a] */
            ii(0x100b_48c6, 1); dec(eax);                               /* dec eax */
            ii(0x100b_48c7, 4); mov(memw[ss, ebp - 20], ax);            /* mov [ebp-0x14], ax */
            ii(0x100b_48cb, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100b_48ce, 4); mov(ax, memw[ds, eax + 28]);            /* mov ax, [eax+0x1c] */
            ii(0x100b_48d2, 3); add(eax, memd[ss, ebp - 60]);           /* add eax, [ebp-0x3c] */
            ii(0x100b_48d5, 1); dec(eax);                               /* dec eax */
            ii(0x100b_48d6, 4); mov(memw[ss, ebp - 18], ax);            /* mov [ebp-0x12], ax */
            ii(0x100b_48da, 7); mov(memd[ss, ebp - 64], 0);             /* mov dword [ebp-0x40], 0x0 */
            ii(0x100b_48e1, 2); jmp(0x100b_48e7, 4); goto l_0x100b_48e7; /* jmp 0x100b48e7 */
        l_0x100b_48e3:
            ii(0x100b_48e3, 4); add(memd[ss, ebp - 64], 2);             /* add dword [ebp-0x40], 0x2 */
        l_0x100b_48e7:
            ii(0x100b_48e7, 4); movsx(eax, memw[ss, ebp - 64]);         /* movsx eax, word [ebp-0x40] */
            ii(0x100b_48eb, 3); cmp(eax, 8);                            /* cmp eax, 0x8 */
            ii(0x100b_48ee, 6); if(jge(0x100b_49be, 0xca)) goto l_0x100b_49be; /* jge 0x100b49be */
            ii(0x100b_48f4, 7); mov(memd[ss, ebp - 68], 0);             /* mov dword [ebp-0x44], 0x0 */
            ii(0x100b_48fb, 2); jmp(0x100b_4903, 6); goto l_0x100b_4903; /* jmp 0x100b4903 */
        l_0x100b_48fd:
            ii(0x100b_48fd, 3); mov(eax, memd[ss, ebp - 68]);           /* mov eax, [ebp-0x44] */
            ii(0x100b_4900, 3); inc(memd[ss, ebp - 68]);                /* inc dword [ebp-0x44] */
        l_0x100b_4903:
            ii(0x100b_4903, 3); mov(eax, memd[ss, ebp - 68]);           /* mov eax, [ebp-0x44] */
            ii(0x100b_4906, 4); cmp(ax, memw[ss, ebp - 60]);            /* cmp ax, [ebp-0x3c] */
            ii(0x100b_490a, 6); if(jge(0x100b_49b9, 0xa9)) goto l_0x100b_49b9; /* jge 0x100b49b9 */
            ii(0x100b_4910, 4); movsx(edx, memw[ss, ebp - 64]);         /* movsx edx, word [ebp-0x40] */
            ii(0x100b_4914, 3); shl(edx, 2);                            /* shl edx, 0x2 */
            ii(0x100b_4917, 5); mov(eax, 0x101c_5348);                  /* mov eax, 0x101c5348 */
            ii(0x100b_491c, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100b_491e, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x100b_4921, 5); call(0x1008_b1a4, -0x2_9782);           /* call 0x1008b1a4 */
            ii(0x100b_4926, 3); lea(edx, memd[ss, ebp - 20]);           /* lea edx, [ebp-0x14] */
            ii(0x100b_4929, 3); lea(eax, memd[ss, ebp - 72]);           /* lea eax, [ebp-0x48] */
            ii(0x100b_492c, 5); call(0x1007_5e64, -0x3_eacd);           /* call 0x10075e64 */
            ii(0x100b_4931, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100b_4933, 3); lea(edx, memd[ss, ebp - 28]);           /* lea edx, [ebp-0x1c] */
            ii(0x100b_4936, 3); lea(eax, memd[ss, ebp - 76]);           /* lea eax, [ebp-0x4c] */
            ii(0x100b_4939, 5); call(0x1007_5e64, -0x3_eada);           /* call 0x10075e64 */
            ii(0x100b_493e, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100b_4940, 5); call(0x100a_5fca, -0xe97b);             /* call 0x100a5fca */
            ii(0x100b_4945, 3); mov(memd[ss, ebp - 80], eax);           /* mov [ebp-0x50], eax */
            ii(0x100b_4948, 4); cmp(memb[ss, ebp - 24], 0);             /* cmp byte [ebp-0x18], 0x0 */
            ii(0x100b_494c, 2); if(jz(0x100b_4957, 9)) goto l_0x100b_4957; /* jz 0x100b4957 */
            ii(0x100b_494e, 3); mov(eax, memd[ss, ebp - 80]);           /* mov eax, [ebp-0x50] */
            ii(0x100b_4951, 4); cmp(ax, memw[ss, ebp - 84]);            /* cmp ax, [ebp-0x54] */
            ii(0x100b_4955, 2); if(jge(0x100b_4982, 0x2b)) goto l_0x100b_4982; /* jge 0x100b4982 */
        l_0x100b_4957:
            ii(0x100b_4957, 4); movsx(eax, memb[ss, ebp - 4]);          /* movsx eax, byte [ebp-0x4] */
            ii(0x100b_495b, 1); push(eax);                              /* push eax */
            ii(0x100b_495c, 4); movsx(ecx, memw[ss, ebp - 18]);         /* movsx ecx, word [ebp-0x12] */
            ii(0x100b_4960, 4); movsx(ebx, memw[ss, ebp - 20]);         /* movsx ebx, word [ebp-0x14] */
            ii(0x100b_4964, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100b_4967, 3); mov(al, memb[ds, eax + 38]);            /* mov al, [eax+0x26] */
            ii(0x100b_496a, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100b_496c, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100b_496f, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100b_4972, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100b_4975, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_4978, 5); call(0x1007_02b9, -0x4_46c4);           /* call 0x100702b9 */
            ii(0x100b_497d, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x100b_4980, 2); if(jnz(0x100b_4984, 2)) goto l_0x100b_4984; /* jnz 0x100b4984 */
        l_0x100b_4982:
            ii(0x100b_4982, 2); jmp(0x100b_499d, 0x19); goto l_0x100b_499d; /* jmp 0x100b499d */
        l_0x100b_4984:
            ii(0x100b_4984, 3); lea(edx, memd[ss, ebp - 20]);           /* lea edx, [ebp-0x14] */
            ii(0x100b_4987, 3); lea(eax, memd[ss, ebp - 88]);           /* lea eax, [ebp-0x58] */
            ii(0x100b_498a, 5); call(0x1007_5e64, -0x3_eb2b);           /* call 0x10075e64 */
            ii(0x100b_498f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_4991, 3); lea(eax, memd[ss, ebp - 52]);           /* lea eax, [ebp-0x34] */
            ii(0x100b_4994, 5); call(0x1011_ff4c, 0x6_b5b3);            /* call 0x1011ff4c */
            ii(0x100b_4999, 2); test(al, al);                           /* test al, al */
            ii(0x100b_499b, 2); if(jnz(0x100b_499f, 2)) goto l_0x100b_499f; /* jnz 0x100b499f */
        l_0x100b_499d:
            ii(0x100b_499d, 2); jmp(0x100b_49b4, 0x15); goto l_0x100b_49b4; /* jmp 0x100b49b4 */
        l_0x100b_499f:
            ii(0x100b_499f, 3); lea(edx, memd[ss, ebp - 20]);           /* lea edx, [ebp-0x14] */
            ii(0x100b_49a2, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_49a5, 5); call(0x1008_8b44, -0x2_be66);           /* call 0x10088b44 */
            ii(0x100b_49aa, 4); mov(memb[ss, ebp - 24], 1);             /* mov byte [ebp-0x18], 0x1 */
            ii(0x100b_49ae, 3); mov(eax, memd[ss, ebp - 80]);           /* mov eax, [ebp-0x50] */
            ii(0x100b_49b1, 3); mov(memd[ss, ebp - 84], eax);           /* mov [ebp-0x54], eax */
        l_0x100b_49b4:
            ii(0x100b_49b4, 5); jmp(0x100b_48fd, -0xbc); goto l_0x100b_48fd; /* jmp 0x100b48fd */
        l_0x100b_49b9:
            ii(0x100b_49b9, 5); jmp(0x100b_48e3, -0xdb); goto l_0x100b_48e3; /* jmp 0x100b48e3 */
        l_0x100b_49be:
            ii(0x100b_49be, 3); mov(al, memb[ss, ebp - 24]);            /* mov al, [ebp-0x18] */
            ii(0x100b_49c1, 3); mov(memb[ss, ebp - 92], al);            /* mov [ebp-0x5c], al */
            ii(0x100b_49c4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_49c6, 3); lea(eax, memd[ss, ebp - 52]);           /* lea eax, [ebp-0x34] */
            ii(0x100b_49c9, 5); call(Definitions.my_dtor_d1, -0x2_bcd2); /* call 0x10088cfc */
            ii(0x100b_49ce, 2); jmp(0x100b_49da, 0xa); goto l_0x100b_49da; /* jmp 0x100b49da */
        //  ii(0x100b_49d0, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x100b_49d2, 3); lea(eax, memd[ss, ebp - 52]);           /* lea eax, [ebp-0x34] */
        //  ii(0x100b_49d5, 5); call(Definitions.my_dtor_d1, -0x2_bcde); /* call 0x10088cfc */
        l_0x100b_49da:
            ii(0x100b_49da, 3); mov(al, memb[ss, ebp - 92]);            /* mov al, [ebp-0x5c] */
            ii(0x100b_49dd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_49df, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_49e0, 1); pop(edi);                               /* pop edi */
            ii(0x100b_49e1, 1); pop(esi);                               /* pop esi */
            ii(0x100b_49e2, 1); ret();                                  /* ret */
        }
    }
}
