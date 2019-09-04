using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_37d1-1baf5d0a")]
        public void Method_1014_37d1()
        {
            ii(0x1014_37d1, 5); push(0x78);                             /* push 0x78 */
            ii(0x1014_37d6, 5); call(Definitions.sys_check_available_stack_size, 0x2_2577); /* call 0x10165d52 */
            ii(0x1014_37db, 1); push(esi);                              /* push esi */
            ii(0x1014_37dc, 1); push(edi);                              /* push edi */
            ii(0x1014_37dd, 1); push(ebp);                              /* push ebp */
            ii(0x1014_37de, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_37e0, 6); sub(esp, 0x54);                         /* sub esp, 0x54 */
            ii(0x1014_37e6, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1014_37e9, 3); mov(memd[ss, ebp - 12], edx);           /* mov [ebp-0xc], edx */
            ii(0x1014_37ec, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x1014_37ef, 3); mov(memd[ss, ebp - 4], ecx);            /* mov [ebp-0x4], ecx */
            ii(0x1014_37f2, 4); or(memb[ss, ebp - 20], 1);              /* or byte [ebp-0x14], 0x1 */
            ii(0x1014_37f6, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x1014_37f9, 5); call(0x1007_64fc, -0xc_d302);           /* call 0x100764fc */
            ii(0x1014_37fe, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x1014_3801, 4); and(memb[ss, ebp - 20], -2 /* 0xfe */); /* and byte [ebp-0x14], 0xfe */
            ii(0x1014_3805, 4); or(memb[ss, ebp - 20], 1);              /* or byte [ebp-0x14], 0x1 */
            ii(0x1014_3809, 3); lea(eax, memd[ss, ebp - 56]);           /* lea eax, [ebp-0x38] */
            ii(0x1014_380c, 5); call(0x1014_4eb0, 0x169f);              /* call 0x10144eb0 */
            ii(0x1014_3811, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1014_3814, 4); and(memb[ss, ebp - 20], -2 /* 0xfe */); /* and byte [ebp-0x14], 0xfe */
            ii(0x1014_3818, 4); cmp(memd[ss, ebp - 8], 0);              /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1014_381c, 2); if(jnz(0x1014_383e, 0x20)) goto l_0x1014_383e; /* jnz 0x1014383e */
            ii(0x1014_381e, 7); mov(memd[ss, ebp - 36], 0);             /* mov dword [ebp-0x24], 0x0 */
            ii(0x1014_3825, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_3827, 3); lea(eax, memd[ss, ebp - 56]);           /* lea eax, [ebp-0x38] */
            ii(0x1014_382a, 5); call(0x1014_4e6c, 0x163d);              /* call 0x10144e6c */
            ii(0x1014_382f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_3831, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x1014_3834, 5); call(0x1007_5f6c, -0xc_d8cd);           /* call 0x10075f6c */
            ii(0x1014_3839, 5); jmp(0x1014_3b60, 0x322); goto l_0x1014_3b60; /* jmp 0x10143b60 */
        l_0x1014_383e:
            ii(0x1014_383e, 3); mov(edx, memd[ss, ebp - 16]);           /* mov edx, [ebp-0x10] */
            ii(0x1014_3841, 3); lea(eax, memd[ss, ebp - 52]);           /* lea eax, [ebp-0x34] */
            ii(0x1014_3844, 5); call(0x100a_b2a8, -0x9_85a1);           /* call 0x100ab2a8 */
            ii(0x1014_3849, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_384c, 3); mov(memd[ss, ebp - 48], eax);           /* mov [ebp-0x30], eax */
            ii(0x1014_384f, 7); mov(memd[ss, ebp - 40], 0);             /* mov dword [ebp-0x28], 0x0 */
            ii(0x1014_3856, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_3859, 3); or(eax, memd[ss, ebp - 12]);            /* or eax, [ebp-0xc] */
            ii(0x1014_385c, 3); mov(memd[ss, ebp - 44], eax);           /* mov [ebp-0x2c], eax */
            ii(0x1014_385f, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1014_3864, 5); call(0x1007_6338, -0xc_d531);           /* call 0x10076338 */
            ii(0x1014_3869, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_386b, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x1014_386e, 5); call(0x1007_643c, -0xc_d437);           /* call 0x1007643c */
        l_0x1014_3873:
            ii(0x1014_3873, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_3875, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x1014_3878, 5); call(0x1013_ad71, -0x8b0c);             /* call 0x1013ad71 */
            ii(0x1014_387d, 2); test(al, al);                           /* test al, al */
            ii(0x1014_387f, 6); if(jz(0x1014_3b30, 0x2ab)) goto l_0x1014_3b30; /* jz 0x10143b30 */
            ii(0x1014_3885, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x1014_3888, 5); call(0x1007_63a0, -0xc_d4ed);           /* call 0x100763a0 */
            ii(0x1014_388d, 5); call(0x1007_6204, -0xc_d68e);           /* call 0x10076204 */
            ii(0x1014_3892, 3); cmp(eax, memd[ss, ebp - 16]);           /* cmp eax, [ebp-0x10] */
            ii(0x1014_3895, 2); if(jnz(0x1014_38a6, 0xf)) goto l_0x1014_38a6; /* jnz 0x101438a6 */
            ii(0x1014_3897, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x1014_389a, 5); call(0x1007_63a0, -0xc_d4ff);           /* call 0x100763a0 */
            ii(0x1014_389f, 5); cmp(memw[ds, eax + 8], 0x28);           /* cmp word [eax+0x8], 0x28 */
            ii(0x1014_38a4, 2); if(jz(0x1014_38a8, 2)) goto l_0x1014_38a8; /* jz 0x101438a8 */
        l_0x1014_38a6:
            ii(0x1014_38a6, 2); jmp(0x1014_38b6, 0xe); goto l_0x1014_38b6; /* jmp 0x101438b6 */
        l_0x1014_38a8:
            ii(0x1014_38a8, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x1014_38ab, 5); call(0x1007_63a0, -0xc_d510);           /* call 0x100763a0 */
            ii(0x1014_38b0, 4); cmp(memb[ds, eax + 61], 8);             /* cmp byte [eax+0x3d], 0x8 */
            ii(0x1014_38b4, 2); if(jnz(0x1014_38b8, 2)) goto l_0x1014_38b8; /* jnz 0x101438b8 */
        l_0x1014_38b6:
            ii(0x1014_38b6, 2); jmp(0x1014_38c6, 0xe); goto l_0x1014_38c6; /* jmp 0x101438c6 */
        l_0x1014_38b8:
            ii(0x1014_38b8, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x1014_38bb, 5); call(0x1007_63a0, -0xc_d520);           /* call 0x100763a0 */
            ii(0x1014_38c0, 4); cmp(memb[ds, eax + 61], 0x1a);          /* cmp byte [eax+0x3d], 0x1a */
            ii(0x1014_38c4, 2); if(jnz(0x1014_38c8, 2)) goto l_0x1014_38c8; /* jnz 0x101438c8 */
        l_0x1014_38c6:
            ii(0x1014_38c6, 2); jmp(0x1014_38d6, 0xe); goto l_0x1014_38d6; /* jmp 0x101438d6 */
        l_0x1014_38c8:
            ii(0x1014_38c8, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x1014_38cb, 5); call(0x1007_63a0, -0xc_d530);           /* call 0x100763a0 */
            ii(0x1014_38d0, 4); cmp(memb[ds, eax + 61], 0x10);          /* cmp byte [eax+0x3d], 0x10 */
            ii(0x1014_38d4, 2); if(jnz(0x1014_38db, 5)) goto l_0x1014_38db; /* jnz 0x101438db */
        l_0x1014_38d6:
            ii(0x1014_38d6, 5); jmp(0x1014_3b23, 0x248); goto l_0x1014_3b23; /* jmp 0x10143b23 */
        l_0x1014_38db:
            ii(0x1014_38db, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x1014_38de, 5); call(0x1007_63a0, -0xc_d543);           /* call 0x100763a0 */
            ii(0x1014_38e3, 3); mov(al, memb[ds, eax + 38]);            /* mov al, [eax+0x26] */
            ii(0x1014_38e6, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1014_38e8, 1); cwde();                                 /* cwde */
            ii(0x1014_38e9, 1); push(eax);                              /* push eax */
            ii(0x1014_38ea, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1014_38ef, 1); push(eax);                              /* push eax */
            ii(0x1014_38f0, 3); lea(eax, memd[ss, ebp - 60]);           /* lea eax, [ebp-0x3c] */
            ii(0x1014_38f3, 1); push(eax);                              /* push eax */
            ii(0x1014_38f4, 3); lea(eax, memd[ss, ebp - 64]);           /* lea eax, [ebp-0x40] */
            ii(0x1014_38f7, 1); push(eax);                              /* push eax */
            ii(0x1014_38f8, 3); lea(eax, memd[ss, ebp - 68]);           /* lea eax, [ebp-0x44] */
            ii(0x1014_38fb, 1); push(eax);                              /* push eax */
            ii(0x1014_38fc, 5); mov(ecx, 0x10);                         /* mov ecx, 0x10 */
            ii(0x1014_3901, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1014_3906, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x1014_3909, 5); call(0x1007_63a0, -0xc_d56e);           /* call 0x100763a0 */
            ii(0x1014_390e, 3); mov(edx, memd[ds, eax + 26]);           /* mov edx, [eax+0x1a] */
            ii(0x1014_3911, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_3914, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x1014_3917, 5); call(0x1007_63a0, -0xc_d57c);           /* call 0x100763a0 */
            ii(0x1014_391c, 3); mov(eax, memd[ds, eax + 24]);           /* mov eax, [eax+0x18] */
            ii(0x1014_391f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_3922, 5); call(0x1014_2b18, -0xe0f);              /* call 0x10142b18 */
            ii(0x1014_3927, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1014_392a, 3); mov(memd[ss, ebp - 72], eax);           /* mov [ebp-0x48], eax */
            ii(0x1014_392d, 2); jmp(0x1014_3973, 0x44); goto l_0x1014_3973; /* jmp 0x10143973 */
        l_0x1014_392f:
            ii(0x1014_392f, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x1014_3932, 5); call(0x1007_63a0, -0xc_d597);           /* call 0x100763a0 */
            ii(0x1014_3937, 3); add(eax, 0x47);                         /* add eax, 0x47 */
            ii(0x1014_393a, 3); mov(memd[ss, ebp - 76], eax);           /* mov [ebp-0x4c], eax */
            ii(0x1014_393d, 3); mov(eax, memd[ss, ebp - 68]);           /* mov eax, [ebp-0x44] */
            ii(0x1014_3940, 3); mov(memd[ss, ebp - 80], eax);           /* mov [ebp-0x50], eax */
            ii(0x1014_3943, 2); jmp(0x1014_3992, 0x4d); goto l_0x1014_3992; /* jmp 0x10143992 */
        l_0x1014_3945:
            ii(0x1014_3945, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x1014_3948, 5); call(0x1007_63a0, -0xc_d5ad);           /* call 0x100763a0 */
            ii(0x1014_394d, 3); add(eax, 0x48);                         /* add eax, 0x48 */
            ii(0x1014_3950, 3); mov(memd[ss, ebp - 76], eax);           /* mov [ebp-0x4c], eax */
            ii(0x1014_3953, 3); mov(eax, memd[ss, ebp - 60]);           /* mov eax, [ebp-0x3c] */
            ii(0x1014_3956, 3); mov(memd[ss, ebp - 80], eax);           /* mov [ebp-0x50], eax */
            ii(0x1014_3959, 2); jmp(0x1014_3992, 0x37); goto l_0x1014_3992; /* jmp 0x10143992 */
        l_0x1014_395b:
            ii(0x1014_395b, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x1014_395e, 5); call(0x1007_63a0, -0xc_d5c3);           /* call 0x100763a0 */
            ii(0x1014_3963, 3); add(eax, 0x49);                         /* add eax, 0x49 */
            ii(0x1014_3966, 3); mov(memd[ss, ebp - 76], eax);           /* mov [ebp-0x4c], eax */
            ii(0x1014_3969, 3); mov(eax, memd[ss, ebp - 64]);           /* mov eax, [ebp-0x40] */
            ii(0x1014_396c, 3); mov(memd[ss, ebp - 80], eax);           /* mov [ebp-0x50], eax */
            ii(0x1014_396f, 2); jmp(0x1014_3992, 0x21); goto l_0x1014_3992; /* jmp 0x10143992 */
        l_0x1014_3971:
            ii(0x1014_3971, 2); jmp(0x1014_3992, 0x1f); goto l_0x1014_3992; /* jmp 0x10143992 */
        l_0x1014_3973:
            ii(0x1014_3973, 4); cmp(memd[ss, ebp - 72], 0x40);          /* cmp dword [ebp-0x48], 0x40 */
            ii(0x1014_3977, 2); if(jb(0x1014_398a, 0x11)) goto l_0x1014_398a; /* jb 0x1014398a */
            ii(0x1014_3979, 4); cmp(memd[ss, ebp - 72], 0x40);          /* cmp dword [ebp-0x48], 0x40 */
            ii(0x1014_397d, 2); if(jbe(0x1014_395b, -0x24)) goto l_0x1014_395b; /* jbe 0x1014395b */
            ii(0x1014_397f, 7); cmp(memd[ss, ebp - 72], 0x80);          /* cmp dword [ebp-0x48], 0x80 */
            ii(0x1014_3986, 2); if(jz(0x1014_392f, -0x59)) goto l_0x1014_392f; /* jz 0x1014392f */
            ii(0x1014_3988, 2); jmp(0x1014_3971, -0x19); goto l_0x1014_3971; /* jmp 0x10143971 */
        l_0x1014_398a:
            ii(0x1014_398a, 4); cmp(memd[ss, ebp - 72], 0x20);          /* cmp dword [ebp-0x48], 0x20 */
            ii(0x1014_398e, 2); if(jz(0x1014_3945, -0x4b)) goto l_0x1014_3945; /* jz 0x10143945 */
            ii(0x1014_3990, 2); jmp(0x1014_3971, -0x21); goto l_0x1014_3971; /* jmp 0x10143971 */
        l_0x1014_3992:
            ii(0x1014_3992, 3); mov(eax, memd[ss, ebp - 76]);           /* mov eax, [ebp-0x4c] */
            ii(0x1014_3995, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_3997, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x1014_3999, 4); movsx(eax, memw[ss, ebp - 80]);         /* movsx eax, word [ebp-0x50] */
            ii(0x1014_399d, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1014_399f, 6); if(jge(0x1014_3b23, 0x17e)) goto l_0x1014_3b23; /* jge 0x10143b23 */
            ii(0x1014_39a5, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x1014_39a8, 5); call(0x1007_63a0, -0xc_d60d);           /* call 0x100763a0 */
            ii(0x1014_39ad, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_39af, 3); mov(dl, memb[ds, eax + 71]);            /* mov dl, [eax+0x47] */
            ii(0x1014_39b2, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x1014_39b5, 5); call(0x1007_63a0, -0xc_d61a);           /* call 0x100763a0 */
            ii(0x1014_39ba, 3); mov(al, memb[ds, eax + 72]);            /* mov al, [eax+0x48] */
            ii(0x1014_39bd, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_39c2, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1014_39c4, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x1014_39c7, 5); call(0x1007_63a0, -0xc_d62c);           /* call 0x100763a0 */
            ii(0x1014_39cc, 3); mov(al, memb[ds, eax + 73]);            /* mov al, [eax+0x49] */
            ii(0x1014_39cf, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_39d4, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1014_39d6, 3); cmp(eax, 0x10);                         /* cmp eax, 0x10 */
            ii(0x1014_39d9, 6); if(jge(0x1014_3a99, 0xba)) goto l_0x1014_3a99; /* jge 0x10143a99 */
            ii(0x1014_39df, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x1014_39e2, 5); call(0x1007_63a0, -0xc_d647);           /* call 0x100763a0 */
            ii(0x1014_39e7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_39e9, 3); mov(dl, memb[ds, eax + 71]);            /* mov dl, [eax+0x47] */
            ii(0x1014_39ec, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x1014_39ef, 5); call(0x1007_63a0, -0xc_d654);           /* call 0x100763a0 */
            ii(0x1014_39f4, 3); mov(al, memb[ds, eax + 73]);            /* mov al, [eax+0x49] */
            ii(0x1014_39f7, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_39fc, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1014_39fe, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x1014_3a01, 5); call(0x1007_63a0, -0xc_d666);           /* call 0x100763a0 */
            ii(0x1014_3a06, 3); mov(al, memb[ds, eax + 72]);            /* mov al, [eax+0x48] */
            ii(0x1014_3a09, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_3a0e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1014_3a10, 5); mov(edx, 0x10);                         /* mov edx, 0x10 */
            ii(0x1014_3a15, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1014_3a17, 3); mov(memd[ss, ebp - 84], edx);           /* mov [ebp-0x54], edx */
            ii(0x1014_3a1a, 3); mov(eax, memd[ss, ebp - 84]);           /* mov eax, [ebp-0x54] */
            ii(0x1014_3a1d, 3); cmp(eax, memd[ss, ebp - 48]);           /* cmp eax, [ebp-0x30] */
            ii(0x1014_3a20, 2); if(jle(0x1014_3a28, 6)) goto l_0x1014_3a28; /* jle 0x10143a28 */
            ii(0x1014_3a22, 3); mov(eax, memd[ss, ebp - 48]);           /* mov eax, [ebp-0x30] */
            ii(0x1014_3a25, 3); mov(memd[ss, ebp - 84], eax);           /* mov [ebp-0x54], eax */
        l_0x1014_3a28:
            ii(0x1014_3a28, 3); mov(eax, memd[ss, ebp - 76]);           /* mov eax, [ebp-0x4c] */
            ii(0x1014_3a2b, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1014_3a2d, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_3a32, 4); movsx(edx, memw[ss, ebp - 80]);         /* movsx edx, word [ebp-0x50] */
            ii(0x1014_3a36, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1014_3a38, 3); cmp(edx, memd[ss, ebp - 84]);           /* cmp edx, [ebp-0x54] */
            ii(0x1014_3a3b, 2); if(jge(0x1014_3a50, 0x13)) goto l_0x1014_3a50; /* jge 0x10143a50 */
            ii(0x1014_3a3d, 3); mov(eax, memd[ss, ebp - 76]);           /* mov eax, [ebp-0x4c] */
            ii(0x1014_3a40, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1014_3a42, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_3a47, 4); movsx(edx, memw[ss, ebp - 80]);         /* movsx edx, word [ebp-0x50] */
            ii(0x1014_3a4b, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1014_3a4d, 3); mov(memd[ss, ebp - 84], edx);           /* mov [ebp-0x54], edx */
        l_0x1014_3a50:
            ii(0x1014_3a50, 3); mov(al, memb[ss, ebp - 84]);            /* mov al, [ebp-0x54] */
            ii(0x1014_3a53, 3); mov(edx, memd[ss, ebp - 76]);           /* mov edx, [ebp-0x4c] */
            ii(0x1014_3a56, 2); add(memb[ds, edx], al);                 /* add [edx], al */
            ii(0x1014_3a58, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x1014_3a5b, 5); call(0x1007_63a0, -0xc_d6c0);           /* call 0x100763a0 */
            ii(0x1014_3a60, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_3a62, 3); mov(al, memb[ss, ebp - 84]);            /* mov al, [ebp-0x54] */
            ii(0x1014_3a65, 3); add(memb[ds, edx + 70], al);            /* add [edx+0x46], al */
            ii(0x1014_3a68, 3); mov(eax, memd[ss, ebp - 84]);           /* mov eax, [ebp-0x54] */
            ii(0x1014_3a6b, 3); add(memd[ss, ebp - 40], eax);           /* add [ebp-0x28], eax */
            ii(0x1014_3a6e, 3); mov(eax, memd[ss, ebp - 84]);           /* mov eax, [ebp-0x54] */
            ii(0x1014_3a71, 3); sub(memd[ss, ebp - 48], eax);           /* sub [ebp-0x30], eax */
            ii(0x1014_3a74, 4); cmp(memd[ss, ebp - 48], 0);             /* cmp dword [ebp-0x30], 0x0 */
            ii(0x1014_3a78, 2); if(jnz(0x1014_3a99, 0x1f)) goto l_0x1014_3a99; /* jnz 0x10143a99 */
            ii(0x1014_3a7a, 3); mov(eax, memd[ss, ebp - 40]);           /* mov eax, [ebp-0x28] */
            ii(0x1014_3a7d, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
            ii(0x1014_3a80, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_3a82, 3); lea(eax, memd[ss, ebp - 56]);           /* lea eax, [ebp-0x38] */
            ii(0x1014_3a85, 5); call(0x1014_4e6c, 0x13e2);              /* call 0x10144e6c */
            ii(0x1014_3a8a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_3a8c, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x1014_3a8f, 5); call(0x1007_5f6c, -0xc_db28);           /* call 0x10075f6c */
            ii(0x1014_3a94, 5); jmp(0x1014_3b60, 0xc7); goto l_0x1014_3b60; /* jmp 0x10143b60 */
        l_0x1014_3a99:
            ii(0x1014_3a99, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x1014_3a9c, 5); call(0x1007_63a0, -0xc_d701);           /* call 0x100763a0 */
            ii(0x1014_3aa1, 3); add(eax, 0x47);                         /* add eax, 0x47 */
            ii(0x1014_3aa4, 1); push(eax);                              /* push eax */
            ii(0x1014_3aa5, 4); movsx(ecx, memw[ss, ebp - 80]);         /* movsx ecx, word [ebp-0x50] */
            ii(0x1014_3aa9, 3); mov(ebx, memd[ss, ebp - 76]);           /* mov ebx, [ebp-0x4c] */
            ii(0x1014_3aac, 5); mov(edx, 0x80);                         /* mov edx, 0x80 */
            ii(0x1014_3ab1, 3); lea(eax, memd[ss, ebp - 56]);           /* lea eax, [ebp-0x38] */
            ii(0x1014_3ab4, 5); call(0x1014_36e7, -0x3d2);              /* call 0x101436e7 */
            ii(0x1014_3ab9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_3abb, 2); if(jnz(0x1014_3ae1, 0x24)) goto l_0x1014_3ae1; /* jnz 0x10143ae1 */
            ii(0x1014_3abd, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x1014_3ac0, 5); call(0x1007_63a0, -0xc_d725);           /* call 0x100763a0 */
            ii(0x1014_3ac5, 3); add(eax, 0x48);                         /* add eax, 0x48 */
            ii(0x1014_3ac8, 1); push(eax);                              /* push eax */
            ii(0x1014_3ac9, 4); movsx(ecx, memw[ss, ebp - 80]);         /* movsx ecx, word [ebp-0x50] */
            ii(0x1014_3acd, 3); mov(ebx, memd[ss, ebp - 76]);           /* mov ebx, [ebp-0x4c] */
            ii(0x1014_3ad0, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x1014_3ad5, 3); lea(eax, memd[ss, ebp - 56]);           /* lea eax, [ebp-0x38] */
            ii(0x1014_3ad8, 5); call(0x1014_36e7, -0x3f6);              /* call 0x101436e7 */
            ii(0x1014_3add, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_3adf, 2); if(jz(0x1014_3ae3, 2)) goto l_0x1014_3ae3; /* jz 0x10143ae3 */
        l_0x1014_3ae1:
            ii(0x1014_3ae1, 2); jmp(0x1014_3b07, 0x24); goto l_0x1014_3b07; /* jmp 0x10143b07 */
        l_0x1014_3ae3:
            ii(0x1014_3ae3, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x1014_3ae6, 5); call(0x1007_63a0, -0xc_d74b);           /* call 0x100763a0 */
            ii(0x1014_3aeb, 3); add(eax, 0x49);                         /* add eax, 0x49 */
            ii(0x1014_3aee, 1); push(eax);                              /* push eax */
            ii(0x1014_3aef, 4); movsx(ecx, memw[ss, ebp - 80]);         /* movsx ecx, word [ebp-0x50] */
            ii(0x1014_3af3, 3); mov(ebx, memd[ss, ebp - 76]);           /* mov ebx, [ebp-0x4c] */
            ii(0x1014_3af6, 5); mov(edx, 0x40);                         /* mov edx, 0x40 */
            ii(0x1014_3afb, 3); lea(eax, memd[ss, ebp - 56]);           /* lea eax, [ebp-0x38] */
            ii(0x1014_3afe, 5); call(0x1014_36e7, -0x41c);              /* call 0x101436e7 */
            ii(0x1014_3b03, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_3b05, 2); if(jz(0x1014_3b23, 0x1c)) goto l_0x1014_3b23; /* jz 0x10143b23 */
        l_0x1014_3b07:
            ii(0x1014_3b07, 3); mov(eax, memd[ss, ebp - 40]);           /* mov eax, [ebp-0x28] */
            ii(0x1014_3b0a, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
            ii(0x1014_3b0d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_3b0f, 3); lea(eax, memd[ss, ebp - 56]);           /* lea eax, [ebp-0x38] */
            ii(0x1014_3b12, 5); call(0x1014_4e6c, 0x1355);              /* call 0x10144e6c */
            ii(0x1014_3b17, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_3b19, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x1014_3b1c, 5); call(0x1007_5f6c, -0xc_dbb5);           /* call 0x10075f6c */
            ii(0x1014_3b21, 2); jmp(0x1014_3b60, 0x3d); goto l_0x1014_3b60; /* jmp 0x10143b60 */
        l_0x1014_3b23:
            ii(0x1014_3b23, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x1014_3b26, 5); call(0x1007_6bf8, -0xc_cf33);           /* call 0x10076bf8 */
            ii(0x1014_3b2b, 5); jmp(0x1014_3873, -0x2bd); goto l_0x1014_3873; /* jmp 0x10143873 */
        l_0x1014_3b30:
            ii(0x1014_3b30, 3); mov(eax, memd[ss, ebp - 40]);           /* mov eax, [ebp-0x28] */
            ii(0x1014_3b33, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
            ii(0x1014_3b36, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_3b38, 3); lea(eax, memd[ss, ebp - 56]);           /* lea eax, [ebp-0x38] */
            ii(0x1014_3b3b, 5); call(0x1014_4e6c, 0x132c);              /* call 0x10144e6c */
            ii(0x1014_3b40, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_3b42, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x1014_3b45, 5); call(0x1007_5f6c, -0xc_dbde);           /* call 0x10075f6c */
            ii(0x1014_3b4a, 2); jmp(0x1014_3b60, 0x14); goto l_0x1014_3b60; /* jmp 0x10143b60 */
        //  ii(0x1014_3b4c, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1014_3b4e, 3); lea(eax, memd[ss, ebp - 56]);           /* lea eax, [ebp-0x38] */
        //  ii(0x1014_3b51, 5); call(0x1014_4e6c, 0x1316);              /* call 0x10144e6c */
        //  ii(0x1014_3b56, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1014_3b58, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
        //  ii(0x1014_3b5b, 5); call(0x1007_5f6c, -0xc_dbf4);           /* call 0x10075f6c */
        l_0x1014_3b60:
            ii(0x1014_3b60, 3); mov(eax, memd[ss, ebp - 36]);           /* mov eax, [ebp-0x24] */
            ii(0x1014_3b63, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_3b65, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_3b66, 1); pop(edi);                               /* pop edi */
            ii(0x1014_3b67, 1); pop(esi);                               /* pop esi */
            ii(0x1014_3b68, 1); ret();                                  /* ret */
        }
    }
}
