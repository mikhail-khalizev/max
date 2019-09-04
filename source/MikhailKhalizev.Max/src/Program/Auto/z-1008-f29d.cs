using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_f29d-fae6b18")]
        public void Method_1008_f29d()
        {
            ii(0x1008_f29d, 5); push(0x60);                             /* push 0x60 */
            ii(0x1008_f2a2, 5); call(Definitions.sys_check_available_stack_size, 0xd_6aab); /* call 0x10165d52 */
            ii(0x1008_f2a7, 1); push(ebx);                              /* push ebx */
            ii(0x1008_f2a8, 1); push(ecx);                              /* push ecx */
            ii(0x1008_f2a9, 1); push(edx);                              /* push edx */
            ii(0x1008_f2aa, 1); push(esi);                              /* push esi */
            ii(0x1008_f2ab, 1); push(edi);                              /* push edi */
            ii(0x1008_f2ac, 1); push(ebp);                              /* push ebp */
            ii(0x1008_f2ad, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_f2af, 6); sub(esp, 0x40);                         /* sub esp, 0x40 */
            ii(0x1008_f2b5, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1008_f2b8, 4); or(memb[ss, ebp - 12], 1);              /* or byte [ebp-0xc], 0x1 */
            ii(0x1008_f2bc, 3); lea(eax, memd[ss, ebp - 60]);           /* lea eax, [ebp-0x3c] */
            ii(0x1008_f2bf, 5); call(0x1008_bbed, -0x36d7);             /* call 0x1008bbed */
            ii(0x1008_f2c4, 3); mov(memd[ss, ebp - 52], eax);           /* mov [ebp-0x34], eax */
            ii(0x1008_f2c7, 4); and(memb[ss, ebp - 12], -2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x1008_f2cb, 3); lea(eax, memd[ss, ebp - 60]);           /* lea eax, [ebp-0x3c] */
            ii(0x1008_f2ce, 5); call(0x1008_a6f8, -0x4bdb);             /* call 0x1008a6f8 */
            ii(0x1008_f2d3, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1008_f2d6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_f2d8, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1008_f2da, 5); call(0x1008_e7e0, -0xaff);              /* call 0x1008e7e0 */
            ii(0x1008_f2df, 4); mov(memb[ss, ebp - 8], 0);              /* mov byte [ebp-0x8], 0x0 */
            ii(0x1008_f2e3, 3); lea(eax, memd[ss, ebp - 48]);           /* lea eax, [ebp-0x30] */
            ii(0x1008_f2e6, 5); call(Definitions.my_ctor_0x101b_4184, -0x1_87fb); /* call 0x10076af0 */
            ii(0x1008_f2eb, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1008_f2f0, 5); call(0x1007_6338, -0x1_8fbd);           /* call 0x10076338 */
            ii(0x1008_f2f5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_f2f7, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x1008_f2fa, 5); call(0x1007_64b8, -0x1_8e47);           /* call 0x100764b8 */
            ii(0x1008_f2ff, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1008_f304, 5); call(0x1007_6338, -0x1_8fd1);           /* call 0x10076338 */
            ii(0x1008_f309, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_f30b, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x1008_f30e, 5); call(0x1007_643c, -0x1_8ed7);           /* call 0x1007643c */
            ii(0x1008_f313, 2); jmp(0x1008_f31d, 8); goto l_0x1008_f31d; /* jmp 0x1008f31d */
        l_0x1008_f315:
            ii(0x1008_f315, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x1008_f318, 5); call(0x1007_6bf8, -0x1_8725);           /* call 0x10076bf8 */
        l_0x1008_f31d:
            ii(0x1008_f31d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_f31f, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x1008_f322, 5); call(0x1013_ad71, 0xa_ba4a);            /* call 0x1013ad71 */
            ii(0x1008_f327, 2); test(al, al);                           /* test al, al */
            ii(0x1008_f329, 6); if(jz(0x1008_f444, 0x115)) goto l_0x1008_f444; /* jz 0x1008f444 */
            ii(0x1008_f32f, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x1008_f332, 5); call(0x1007_63a0, -0x1_8f97);           /* call 0x100763a0 */
            ii(0x1008_f337, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_f339, 3); mov(dl, memb[ds, eax + 38]);            /* mov dl, [eax+0x26] */
            ii(0x1008_f33c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_f33f, 3); mov(eax, memd[ds, eax + 7]);            /* mov eax, [eax+0x7] */
            ii(0x1008_f342, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_f345, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1008_f347, 2); if(jnz(0x1008_f358, 0xf)) goto l_0x1008_f358; /* jnz 0x1008f358 */
            ii(0x1008_f349, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x1008_f34c, 5); call(0x1007_63a0, -0x1_8fb1);           /* call 0x100763a0 */
            ii(0x1008_f351, 5); cmp(memw[ds, eax + 8], 0x28);           /* cmp word [eax+0x8], 0x28 */
            ii(0x1008_f356, 2); if(jz(0x1008_f35d, 5)) goto l_0x1008_f35d; /* jz 0x1008f35d */
        l_0x1008_f358:
            ii(0x1008_f358, 5); jmp(0x1008_f43f, 0xe2); goto l_0x1008_f43f; /* jmp 0x1008f43f */
        l_0x1008_f35d:
            ii(0x1008_f35d, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x1008_f360, 5); call(0x1007_63a0, -0x1_8fc5);           /* call 0x100763a0 */
            ii(0x1008_f365, 4); mov(ax, memw[ds, eax + 26]);            /* mov ax, [eax+0x1a] */
            ii(0x1008_f369, 1); dec(eax);                               /* dec eax */
            ii(0x1008_f36a, 4); mov(memw[ss, ebp - 48], ax);            /* mov [ebp-0x30], ax */
            ii(0x1008_f36e, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x1008_f371, 5); call(0x1007_63a0, -0x1_8fd6);           /* call 0x100763a0 */
            ii(0x1008_f376, 4); mov(ax, memw[ds, eax + 28]);            /* mov ax, [eax+0x1c] */
            ii(0x1008_f37a, 5); add(eax, 2);                            /* add eax, 0x2 */
            ii(0x1008_f37f, 4); mov(memw[ss, ebp - 46], ax);            /* mov [ebp-0x2e], ax */
            ii(0x1008_f383, 7); mov(memd[ss, ebp - 20], 0);             /* mov dword [ebp-0x14], 0x0 */
            ii(0x1008_f38a, 2); jmp(0x1008_f390, 4); goto l_0x1008_f390; /* jmp 0x1008f390 */
        l_0x1008_f38c:
            ii(0x1008_f38c, 4); add(memd[ss, ebp - 20], 2);             /* add dword [ebp-0x14], 0x2 */
        l_0x1008_f390:
            ii(0x1008_f390, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x1008_f394, 3); cmp(eax, 8);                            /* cmp eax, 0x8 */
            ii(0x1008_f397, 2); if(jge(0x1008_f39f, 6)) goto l_0x1008_f39f; /* jge 0x1008f39f */
            ii(0x1008_f399, 4); cmp(memb[ss, ebp - 8], 0);              /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1008_f39d, 2); if(jz(0x1008_f3a4, 5)) goto l_0x1008_f3a4; /* jz 0x1008f3a4 */
        l_0x1008_f39f:
            ii(0x1008_f39f, 5); jmp(0x1008_f439, 0x95); goto l_0x1008_f439; /* jmp 0x1008f439 */
        l_0x1008_f3a4:
            ii(0x1008_f3a4, 7); mov(memd[ss, ebp - 16], 0);             /* mov dword [ebp-0x10], 0x0 */
            ii(0x1008_f3ab, 2); jmp(0x1008_f3b3, 6); goto l_0x1008_f3b3; /* jmp 0x1008f3b3 */
        l_0x1008_f3ad:
            ii(0x1008_f3ad, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1008_f3b0, 3); inc(memd[ss, ebp - 16]);                /* inc dword [ebp-0x10] */
        l_0x1008_f3b3:
            ii(0x1008_f3b3, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x1008_f3b7, 3); cmp(eax, 3);                            /* cmp eax, 0x3 */
            ii(0x1008_f3ba, 2); if(jge(0x1008_f3c2, 6)) goto l_0x1008_f3c2; /* jge 0x1008f3c2 */
            ii(0x1008_f3bc, 4); cmp(memb[ss, ebp - 8], 0);              /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1008_f3c0, 2); if(jz(0x1008_f3c7, 5)) goto l_0x1008_f3c7; /* jz 0x1008f3c7 */
        l_0x1008_f3c2:
            ii(0x1008_f3c2, 5); jmp(0x1008_f434, 0x6d); goto l_0x1008_f434; /* jmp 0x1008f434 */
        l_0x1008_f3c7:
            ii(0x1008_f3c7, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x1008_f3cb, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1008_f3ce, 5); mov(edx, 0x101c_5348);                  /* mov edx, 0x101c5348 */
            ii(0x1008_f3d3, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1008_f3d5, 3); lea(eax, memd[ss, ebp - 48]);           /* lea eax, [ebp-0x30] */
            ii(0x1008_f3d8, 5); call(0x1008_b1a4, -0x4239);             /* call 0x1008b1a4 */
            ii(0x1008_f3dd, 4); movsx(eax, memw[ss, ebp - 48]);         /* movsx eax, word [ebp-0x30] */
            ii(0x1008_f3e1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_f3e3, 2); if(jl(0x1008_f3f1, 0xc)) goto l_0x1008_f3f1; /* jl 0x1008f3f1 */
            ii(0x1008_f3e5, 3); mov(eax, memd[ss, ebp - 48]);           /* mov eax, [ebp-0x30] */
            ii(0x1008_f3e8, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x1008_f3ef, 2); if(jl(0x1008_f3f3, 2)) goto l_0x1008_f3f3; /* jl 0x1008f3f3 */
        l_0x1008_f3f1:
            ii(0x1008_f3f1, 2); jmp(0x1008_f3fb, 8); goto l_0x1008_f3fb; /* jmp 0x1008f3fb */
        l_0x1008_f3f3:
            ii(0x1008_f3f3, 4); movsx(eax, memw[ss, ebp - 46]);         /* movsx eax, word [ebp-0x2e] */
            ii(0x1008_f3f7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_f3f9, 2); if(jge(0x1008_f3fd, 2)) goto l_0x1008_f3fd; /* jge 0x1008f3fd */
        l_0x1008_f3fb:
            ii(0x1008_f3fb, 2); jmp(0x1008_f409, 0xc); goto l_0x1008_f409; /* jmp 0x1008f409 */
        l_0x1008_f3fd:
            ii(0x1008_f3fd, 3); mov(eax, memd[ss, ebp - 46]);           /* mov eax, [ebp-0x2e] */
            ii(0x1008_f400, 7); cmp(ax, memw[ds, 0x101c_8174]);         /* cmp ax, [0x101c8174] */
            ii(0x1008_f407, 2); if(jl(0x1008_f40b, 2)) goto l_0x1008_f40b; /* jl 0x1008f40b */
        l_0x1008_f409:
            ii(0x1008_f409, 2); jmp(0x1008_f429, 0x1e); goto l_0x1008_f429; /* jmp 0x1008f429 */
        l_0x1008_f40b:
            ii(0x1008_f40b, 4); movsx(ebx, memw[ss, ebp - 46]);         /* movsx ebx, word [ebp-0x2e] */
            ii(0x1008_f40f, 4); movsx(edx, memw[ss, ebp - 48]);         /* movsx edx, word [ebp-0x30] */
            ii(0x1008_f413, 3); lea(eax, memd[ss, ebp - 60]);           /* lea eax, [ebp-0x3c] */
            ii(0x1008_f416, 5); call(0x1008_a728, -0x4cf3);             /* call 0x1008a728 */
            ii(0x1008_f41b, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1008_f41d, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1008_f41f, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_f424, 3); cmp(eax, 2);                            /* cmp eax, 0x2 */
            ii(0x1008_f427, 2); if(jz(0x1008_f42b, 2)) goto l_0x1008_f42b; /* jz 0x1008f42b */
        l_0x1008_f429:
            ii(0x1008_f429, 2); jmp(0x1008_f42f, 4); goto l_0x1008_f42f; /* jmp 0x1008f42f */
        l_0x1008_f42b:
            ii(0x1008_f42b, 4); mov(memb[ss, ebp - 8], 1);              /* mov byte [ebp-0x8], 0x1 */
        l_0x1008_f42f:
            ii(0x1008_f42f, 5); jmp(0x1008_f3ad, -0x87); goto l_0x1008_f3ad; /* jmp 0x1008f3ad */
        l_0x1008_f434:
            ii(0x1008_f434, 5); jmp(0x1008_f38c, -0xad); goto l_0x1008_f38c; /* jmp 0x1008f38c */
        l_0x1008_f439:
            ii(0x1008_f439, 4); cmp(memb[ss, ebp - 8], 0);              /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1008_f43d, 2); if(jnz(0x1008_f444, 5)) goto l_0x1008_f444; /* jnz 0x1008f444 */
        l_0x1008_f43f:
            ii(0x1008_f43f, 5); jmp(0x1008_f315, -0x12f); goto l_0x1008_f315; /* jmp 0x1008f315 */
        l_0x1008_f444:
            ii(0x1008_f444, 4); cmp(memb[ss, ebp - 8], 0);              /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1008_f448, 2); if(jnz(0x1008_f463, 0x19)) goto l_0x1008_f463; /* jnz 0x1008f463 */
            ii(0x1008_f44a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_f44c, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x1008_f44f, 5); call(0x1007_5f6c, -0x1_94e8);           /* call 0x10075f6c */
            ii(0x1008_f454, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_f456, 3); lea(eax, memd[ss, ebp - 60]);           /* lea eax, [ebp-0x3c] */
            ii(0x1008_f459, 5); call(0x1008_bc9f, -0x37bf);             /* call 0x1008bc9f */
            ii(0x1008_f45e, 5); jmp(0x1008_f523, 0xc0); goto l_0x1008_f523; /* jmp 0x1008f523 */
        l_0x1008_f463:
            ii(0x1008_f463, 3); lea(eax, memd[ss, ebp - 60]);           /* lea eax, [ebp-0x3c] */
            ii(0x1008_f466, 5); call(0x1008_a6f8, -0x4d73);             /* call 0x1008a6f8 */
            ii(0x1008_f46b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_f46d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_f470, 5); call(0x1008_eb17, -0x95e);              /* call 0x1008eb17 */
            ii(0x1008_f475, 5); mov(eax, 0x24);                         /* mov eax, 0x24 */
            ii(0x1008_f47a, 5); call(Definitions.sys_new, 0xd_6981);    /* call 0x10165e00 */
            ii(0x1008_f47f, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1008_f482, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1008_f485, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x1008_f488, 4); cmp(memd[ss, ebp - 28], 0);             /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1008_f48c, 2); if(jz(0x1008_f4c2, 0x34)) goto l_0x1008_f4c2; /* jz 0x1008f4c2 */
            ii(0x1008_f48e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1008_f490, 1); push(eax);                              /* push eax */
            ii(0x1008_f491, 3); lea(edx, memd[ss, ebp - 48]);           /* lea edx, [ebp-0x30] */
            ii(0x1008_f494, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x1008_f497, 5); call(0x1007_5e64, -0x1_9638);           /* call 0x10075e64 */
            ii(0x1008_f49c, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1008_f49e, 5); mov(ebx, 3);                            /* mov ebx, 0x3 */
            ii(0x1008_f4a3, 3); lea(eax, memd[ss, ebp - 60]);           /* lea eax, [ebp-0x3c] */
            ii(0x1008_f4a6, 5); call(0x1008_a6f8, -0x4db3);             /* call 0x1008a6f8 */
            ii(0x1008_f4ab, 3); mov(esi, memd[ss, ebp - 24]);           /* mov esi, [ebp-0x18] */
            ii(0x1008_f4ae, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_f4b0, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1008_f4b2, 5); call(0x100c_7dd0, 0x3_8919);            /* call 0x100c7dd0 */
            ii(0x1008_f4b7, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x1008_f4ba, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x1008_f4bd, 3); mov(memd[ss, ebp - 64], eax);           /* mov [ebp-0x40], eax */
            ii(0x1008_f4c0, 2); jmp(0x1008_f4c8, 6); goto l_0x1008_f4c8; /* jmp 0x1008f4c8 */
        l_0x1008_f4c2:
            ii(0x1008_f4c2, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x1008_f4c5, 3); mov(memd[ss, ebp - 64], eax);           /* mov [ebp-0x40], eax */
        l_0x1008_f4c8:
            ii(0x1008_f4c8, 3); mov(edx, memd[ss, ebp - 64]);           /* mov edx, [ebp-0x40] */
            ii(0x1008_f4cb, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x1008_f4ce, 5); call(0x1008_96e0, -0x5df3);             /* call 0x100896e0 */
            ii(0x1008_f4d3, 5); mov(ebx, 3);                            /* mov ebx, 0x3 */
            ii(0x1008_f4d8, 3); lea(eax, memd[ss, ebp - 60]);           /* lea eax, [ebp-0x3c] */
            ii(0x1008_f4db, 5); call(0x1008_a6f8, -0x4de8);             /* call 0x1008a6f8 */
            ii(0x1008_f4e0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_f4e2, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_f4e5, 5); call(0x1008_ef9c, -0x54e);              /* call 0x1008ef9c */
            ii(0x1008_f4ea, 2); test(al, al);                           /* test al, al */
            ii(0x1008_f4ec, 2); if(jnz(0x1008_f505, 0x17)) goto l_0x1008_f505; /* jnz 0x1008f505 */
            ii(0x1008_f4ee, 5); mov(ebx, 4);                            /* mov ebx, 0x4 */
            ii(0x1008_f4f3, 3); lea(eax, memd[ss, ebp - 60]);           /* lea eax, [ebp-0x3c] */
            ii(0x1008_f4f6, 5); call(0x1008_a6f8, -0x4e03);             /* call 0x1008a6f8 */
            ii(0x1008_f4fb, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_f4fd, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_f500, 5); call(0x1008_ef9c, -0x569);              /* call 0x1008ef9c */
        l_0x1008_f505:
            ii(0x1008_f505, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_f507, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x1008_f50a, 5); call(0x1008_9600, -0x5f0f);             /* call 0x10089600 */
            ii(0x1008_f50f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_f511, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x1008_f514, 5); call(0x1007_5f6c, -0x1_95ad);           /* call 0x10075f6c */
            ii(0x1008_f519, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_f51b, 3); lea(eax, memd[ss, ebp - 60]);           /* lea eax, [ebp-0x3c] */
            ii(0x1008_f51e, 5); call(0x1008_bc9f, -0x3884);             /* call 0x1008bc9f */
        l_0x1008_f523:
            ii(0x1008_f523, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_f525, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_f526, 1); pop(edi);                               /* pop edi */
            ii(0x1008_f527, 1); pop(esi);                               /* pop esi */
            ii(0x1008_f528, 1); pop(edx);                               /* pop edx */
            ii(0x1008_f529, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_f52a, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_f52b, 1); ret();                                  /* ret */
        }
    }
}
