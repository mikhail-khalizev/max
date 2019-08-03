using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c78dc399-cc8a-4341-8dc5-e5614018471b")]
        public void Method_100a_8e92()
        {
            ii(0x100a_8e92, 5); pushd(0x4c);                            /* push 0x4c */
            ii(0x100a_8e97, 5); calld(Definitions.sys_check_available_stack_size, 0xbceb6); /* call 0x10165d52 */
            ii(0x100a_8e9c, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_8e9d, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_8e9e, 1); pushd(edx);                             /* push edx */
            ii(0x100a_8e9f, 1); pushd(esi);                             /* push esi */
            ii(0x100a_8ea0, 1); pushd(edi);                             /* push edi */
            ii(0x100a_8ea1, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_8ea2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_8ea4, 6); sub(esp, 0x30);                         /* sub esp, 0x30 */
            ii(0x100a_8eaa, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_8ead, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_8eb0, 5); calld(Definitions.my_ctor_0x101b4184, -0x323c5); /* call 0x10076af0 */
            ii(0x100a_8eb5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_8eb8, 4); test(memb_a32[ds, eax + 0x13], 0x2);    /* test byte [eax+0x13], 0x2 */
            ii(0x100a_8ebc, 6); if(jzd(0x100a_8ffd, 0x13b)) goto l_0x100a_8ffd; /* jz 0x100a8ffd */
            ii(0x100a_8ec2, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x100a_8ec6, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_8ec9, 5); calld(0x1007_64fc, -0x329d2);           /* call 0x100764fc */
            ii(0x100a_8ece, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100a_8ed1, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x100a_8ed5, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x100a_8ed8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_8edb, 5); calld(0x1015_2532, 0xa9652);            /* call 0x10152532 */
            ii(0x100a_8ee0, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100a_8ee3, 4); mov(memw_a32[ss, ebp - 0x10], ax);      /* mov [ebp-0x10], ax */
            ii(0x100a_8ee7, 2); jmpd(0x100a_8ef0, 0x7); goto l_0x100a_8ef0; /* jmp 0x100a8ef0 */
        l_0x100a_8ee9:
            ii(0x100a_8ee9, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_8eec, 4); inc(memw_a32[ss, ebp - 0x10]);          /* inc word [ebp-0x10] */
        l_0x100a_8ef0:
            ii(0x100a_8ef0, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100a_8ef4, 3); cmp(eax, memd_a32[ss, ebp - 0x20]);     /* cmp eax, [ebp-0x20] */
            ii(0x100a_8ef7, 6); if(jged(0x100a_8ff3, 0xf6)) goto l_0x100a_8ff3; /* jge 0x100a8ff3 */
            ii(0x100a_8efd, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100a_8f00, 4); mov(memw_a32[ss, ebp - 0xe], ax);       /* mov [ebp-0xe], ax */
            ii(0x100a_8f04, 2); jmpd(0x100a_8f0d, 0x7); goto l_0x100a_8f0d; /* jmp 0x100a8f0d */
        l_0x100a_8f06:
            ii(0x100a_8f06, 3); mov(eax, memd_a32[ss, ebp - 0xe]);      /* mov eax, [ebp-0xe] */
            ii(0x100a_8f09, 4); inc(memw_a32[ss, ebp - 0xe]);           /* inc word [ebp-0xe] */
        l_0x100a_8f0d:
            ii(0x100a_8f0d, 4); movsx(eax, memw_a32[ss, ebp - 0xe]);    /* movsx eax, word [ebp-0xe] */
            ii(0x100a_8f11, 3); cmp(eax, memd_a32[ss, ebp - 0x1c]);     /* cmp eax, [ebp-0x1c] */
            ii(0x100a_8f14, 6); if(jged(0x100a_8fee, 0xd4)) goto l_0x100a_8fee; /* jge 0x100a8fee */
            ii(0x100a_8f1a, 4); movsx(edx, memw_a32[ss, ebp - 0xe]);    /* movsx edx, word [ebp-0xe] */
            ii(0x100a_8f1e, 5); mov(eax, memd_a32[ds, 0x101c_8170]);    /* mov eax, [0x101c8170] */
            ii(0x100a_8f23, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_8f26, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100a_8f29, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100a_8f2d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100a_8f2f, 6); mov(edx, memd_a32[ds, 0x101c_9454]);    /* mov edx, [0x101c9454] */
            ii(0x100a_8f35, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100a_8f37, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_8f39, 2); mov(al, memb_a32[ds, edx]);             /* mov al, [edx] */
            ii(0x100a_8f3b, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x100a_8f3e, 4); movsx(ebx, memw_a32[ss, ebp - 0xe]);    /* movsx ebx, word [ebp-0xe] */
            ii(0x100a_8f42, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x100a_8f46, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x100a_8f4b, 5); calld(0x1010_3541, 0x5a5f1);            /* call 0x10103541 */
            ii(0x100a_8f50, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_8f52, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_8f55, 5); calld(0x1007_643c, -0x32b1e);           /* call 0x1007643c */
            ii(0x100a_8f5a, 2); jmpd(0x100a_8f64, 0x8); goto l_0x100a_8f64; /* jmp 0x100a8f64 */
        l_0x100a_8f5c:
            ii(0x100a_8f5c, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_8f5f, 5); calld(0x1007_6bf8, -0x3236c);           /* call 0x10076bf8 */
        l_0x100a_8f64:
            ii(0x100a_8f64, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_8f66, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_8f69, 5); calld(0x1013_ad71, 0x91e03);            /* call 0x1013ad71 */
            ii(0x100a_8f6e, 2); test(al, al);                           /* test al, al */
            ii(0x100a_8f70, 2); if(jzd(0x100a_8fce, 0x5c)) goto l_0x100a_8fce; /* jz 0x100a8fce */
            ii(0x100a_8f72, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_8f75, 5); calld(0x1007_63a0, -0x32bda);           /* call 0x100763a0 */
            ii(0x100a_8f7a, 5); cmp(memw_a32[ds, eax + 0x8], 0x27);     /* cmp word [eax+0x8], 0x27 */
            ii(0x100a_8f7f, 2); if(jnzd(0x100a_8f85, 0x4)) goto l_0x100a_8f85; /* jnz 0x100a8f85 */
            ii(0x100a_8f81, 4); or(memd_a32[ss, ebp - 0x2c], 0x1);      /* or dword [ebp-0x2c], 0x1 */
        l_0x100a_8f85:
            ii(0x100a_8f85, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_8f88, 5); calld(0x1007_63a0, -0x32bed);           /* call 0x100763a0 */
            ii(0x100a_8f8d, 5); cmp(memw_a32[ds, eax + 0x8], 0x21);     /* cmp word [eax+0x8], 0x21 */
            ii(0x100a_8f92, 2); if(jnzd(0x100a_8f9b, 0x7)) goto l_0x100a_8f9b; /* jnz 0x100a8f9b */
            ii(0x100a_8f94, 7); mov(memd_a32[ss, ebp - 0x2c], 0x1);     /* mov dword [ebp-0x2c], 0x1 */
        l_0x100a_8f9b:
            ii(0x100a_8f9b, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_8f9e, 5); calld(0x1007_63a0, -0x32c03);           /* call 0x100763a0 */
            ii(0x100a_8fa3, 5); cmp(memw_a32[ds, eax + 0x8], 0xc);      /* cmp word [eax+0x8], 0xc */
            ii(0x100a_8fa8, 2); if(jzd(0x100a_8fc1, 0x17)) goto l_0x100a_8fc1; /* jz 0x100a8fc1 */
            ii(0x100a_8faa, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_8fad, 5); calld(0x1007_63a0, -0x32c12);           /* call 0x100763a0 */
            ii(0x100a_8fb2, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x100a_8fb5, 5); and(eax, 0x201);                        /* and eax, 0x201 */
            ii(0x100a_8fba, 5); cmp(eax, 0x200);                        /* cmp eax, 0x200 */
            ii(0x100a_8fbf, 2); if(jzd(0x100a_8fc3, 0x2)) goto l_0x100a_8fc3; /* jz 0x100a8fc3 */
        l_0x100a_8fc1:
            ii(0x100a_8fc1, 2); jmpd(0x100a_8fcc, 0x9); goto l_0x100a_8fcc; /* jmp 0x100a8fcc */
        l_0x100a_8fc3:
            ii(0x100a_8fc3, 7); mov(memd_a32[ss, ebp - 0x2c], 0);       /* mov dword [ebp-0x2c], 0x0 */
            ii(0x100a_8fca, 2); jmpd(0x100a_8fce, 0x2); goto l_0x100a_8fce; /* jmp 0x100a8fce */
        l_0x100a_8fcc:
            ii(0x100a_8fcc, 2); jmpd(0x100a_8f5c, -0x72); goto l_0x100a_8f5c; /* jmp 0x100a8f5c */
        l_0x100a_8fce:
            ii(0x100a_8fce, 4); movsx(ebx, memw_a32[ss, ebp - 0x2c]);   /* movsx ebx, word [ebp-0x2c] */
            ii(0x100a_8fd2, 3); lea(edx, ebp - 0x10);                   /* lea edx, [ebp-0x10] */
            ii(0x100a_8fd5, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100a_8fd8, 5); calld(0x1007_5e64, -0x33179);           /* call 0x10075e64 */
            ii(0x100a_8fdd, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_8fdf, 5); mov(eax, 0x101c_34d8);                  /* mov eax, 0x101c34d8 */
            ii(0x100a_8fe4, 5); calld(0x100c_95c4, 0x205db);            /* call 0x100c95c4 */
            ii(0x100a_8fe9, 5); jmpd(0x100a_8f06, -0xe8); goto l_0x100a_8f06; /* jmp 0x100a8f06 */
        l_0x100a_8fee:
            ii(0x100a_8fee, 5); jmpd(0x100a_8ee9, -0x10a); goto l_0x100a_8ee9; /* jmp 0x100a8ee9 */
        l_0x100a_8ff3:
            ii(0x100a_8ff3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_8ff5, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_8ff8, 5); calld(0x1007_5f6c, -0x33091);           /* call 0x10075f6c */
        l_0x100a_8ffd:
            ii(0x100a_8ffd, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x100a_9004, 2); jmpd(0x100a_900c, 0x6); goto l_0x100a_900c; /* jmp 0x100a900c */
        l_0x100a_9006:
            ii(0x100a_9006, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_9009, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x100a_900c:
            ii(0x100a_900c, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100a_9010, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100a_9013, 2); if(jged(0x100a_904a, 0x35)) goto l_0x100a_904a; /* jge 0x100a904a */
            ii(0x100a_9015, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100a_9019, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100a_901f, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100a_9025, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_902a, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100a_902d, 2); if(jnzd(0x100a_9048, 0x19)) goto l_0x100a_9048; /* jnz 0x100a9048 */
            ii(0x100a_902f, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_9032, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100a_9036, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x100a_903c, 5); mov(ebx, 0x101c_31c4);                  /* mov ebx, 0x101c31c4 */
            ii(0x100a_9041, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100a_9043, 5); calld(0x100c_35e5, 0x1a59d);            /* call 0x100c35e5 */
        l_0x100a_9048:
            ii(0x100a_9048, 2); jmpd(0x100a_9006, -0x44); goto l_0x100a_9006; /* jmp 0x100a9006 */
        l_0x100a_904a:
            ii(0x100a_904a, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_904d, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_9052, 5); calld(0x100a_5e7b, -0x31dc);            /* call 0x100a5e7b */
            ii(0x100a_9057, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_9059, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_905a, 1); popd(edi);                              /* pop edi */
            ii(0x100a_905b, 1); popd(esi);                              /* pop esi */
            ii(0x100a_905c, 1); popd(edx);                              /* pop edx */
            ii(0x100a_905d, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_905e, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_905f, 1); retd(); return;                         /* ret */
        }
    }
}
