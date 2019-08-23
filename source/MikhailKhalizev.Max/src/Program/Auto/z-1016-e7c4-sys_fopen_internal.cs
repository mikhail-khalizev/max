using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_e7c4-5a2e18f4")]
        public void /* sys */ sys_fopen_internal()
        {
            ii(0x1016_e7c4, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_e7c5, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_e7c6, 1); pushd(esi);                             /* push esi */
            ii(0x1016_e7c7, 1); pushd(edi);                             /* push edi */
            ii(0x1016_e7c8, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_e7c9, 6); sub(esp, 0xa4);                         /* sub esp, 0xa4 */
            ii(0x1016_e7cf, 2); mov(ebp, eax);                          /* mov ebp, eax */
            ii(0x1016_e7d1, 7); mov(memd_a32[ss, esp + 0xa0], edx);     /* mov [esp+0xa0], edx */
            ii(0x1016_e7d8, 6); mov(edx, memd_a32[ds, 0x101b_e1c0]);    /* mov edx, [0x101be1c0] */
            ii(0x1016_e7de, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1016_e7e0, 6); if(jzd(0x1016_ea5b, 0x275)) goto l_0x1016_ea5b; /* jz 0x1016ea5b */
            ii(0x1016_e7e6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_e7e8, 6); if(jzd(0x1016_ea5b, 0x26d)) goto l_0x1016_ea5b; /* jz 0x1016ea5b */
            ii(0x1016_e7ee, 8); cmp(memd_a32[ss, esp + 0xa0], 0);       /* cmp dword [esp+0xa0], 0x0 */
            ii(0x1016_e7f6, 6); if(jzd(0x1016_ea5b, 0x25f)) goto l_0x1016_ea5b; /* jz 0x1016ea5b */
            ii(0x1016_e7fc, 4); cmp(memd_a32[ds, edx + 0x3c], 0xa);     /* cmp dword [edx+0x3c], 0xa */
            ii(0x1016_e800, 6); if(jged(0x1016_ea5b, 0x255)) goto l_0x1016_ea5b; /* jge 0x1016ea5b */
            ii(0x1016_e806, 7); mov(edx, memd_a32[ss, esp + 0xa0]);     /* mov edx, [esp+0xa0] */
            ii(0x1016_e80d, 5); mov(ebx, 0xffff_ffff);                  /* mov ebx, 0xffffffff */
            ii(0x1016_e812, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1016_e817, 3); cmp(memb_a32[ds, edx], 0);              /* cmp byte [edx], 0x0 */
            ii(0x1016_e81a, 2); if(jzd(0x1016_e851, 0x35)) goto l_0x1016_e851; /* jz 0x1016e851 */
        l_0x1016_e81c:
            ii(0x1016_e81c, 2); mov(al, memb_a32[ds, edx]);             /* mov al, [edx] */
            ii(0x1016_e81e, 2); cmp(al, 0x62);                          /* cmp al, 0x62 */
            ii(0x1016_e820, 2); if(jbd(0x1016_e830, 0xe)) goto l_0x1016_e830; /* jb 0x1016e830 */
            ii(0x1016_e822, 2); if(jbed(0x1016_e843, 0x1f)) goto l_0x1016_e843; /* jbe 0x1016e843 */
            ii(0x1016_e824, 2); cmp(al, 0x72);                          /* cmp al, 0x72 */
            ii(0x1016_e826, 2); if(jbd(0x1016_e849, 0x21)) goto l_0x1016_e849; /* jb 0x1016e849 */
            ii(0x1016_e828, 2); if(jbed(0x1016_e83c, 0x12)) goto l_0x1016_e83c; /* jbe 0x1016e83c */
            ii(0x1016_e82a, 2); cmp(al, 0x77);                          /* cmp al, 0x77 */
            ii(0x1016_e82c, 2); if(jzd(0x1016_e847, 0x19)) goto l_0x1016_e847; /* jz 0x1016e847 */
            ii(0x1016_e82e, 2); jmpd(0x1016_e849, 0x19); goto l_0x1016_e849; /* jmp 0x1016e849 */
        l_0x1016_e830:
            ii(0x1016_e830, 2); cmp(al, 0x2b);                          /* cmp al, 0x2b */
            ii(0x1016_e832, 2); if(jbd(0x1016_e849, 0x15)) goto l_0x1016_e849; /* jb 0x1016e849 */
            ii(0x1016_e834, 2); if(jbed(0x1016_e847, 0x11)) goto l_0x1016_e847; /* jbe 0x1016e847 */
            ii(0x1016_e836, 2); cmp(al, 0x61);                          /* cmp al, 0x61 */
            ii(0x1016_e838, 2); if(jzd(0x1016_e847, 0xd)) goto l_0x1016_e847; /* jz 0x1016e847 */
            ii(0x1016_e83a, 2); jmpd(0x1016_e849, 0xd); goto l_0x1016_e849; /* jmp 0x1016e849 */
        l_0x1016_e83c:
            ii(0x1016_e83c, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1016_e841, 2); jmpd(0x1016_e849, 0x6); goto l_0x1016_e849; /* jmp 0x1016e849 */
        l_0x1016_e843:
            ii(0x1016_e843, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_e845, 2); jmpd(0x1016_e849, 0x2); goto l_0x1016_e849; /* jmp 0x1016e849 */
        l_0x1016_e847:
            ii(0x1016_e847, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
        l_0x1016_e849:
            ii(0x1016_e849, 3); mov(ah, memb_a32[ds, edx + 0x1]);       /* mov ah, [edx+0x1] */
            ii(0x1016_e84c, 1); inc(edx);                               /* inc edx */
            ii(0x1016_e84d, 2); test(ah, ah);                           /* test ah, ah */
            ii(0x1016_e84f, 2); if(jnzd(0x1016_e81c, -0x35)) goto l_0x1016_e81c; /* jnz 0x1016e81c */
        l_0x1016_e851:
            ii(0x1016_e851, 3); cmp(ebx, -0x1 /* 0xff */);              /* cmp ebx, 0xffffffff */
            ii(0x1016_e854, 6); if(jzd(0x1016_ea5b, 0x201)) goto l_0x1016_ea5b; /* jz 0x1016ea5b */
            ii(0x1016_e85a, 5); mov(esi, 0x1);                          /* mov esi, 0x1 */
            ii(0x1016_e85f, 2); cmp(ecx, esi);                          /* cmp ecx, esi */
            ii(0x1016_e861, 3); setz(al);                               /* setz al */
            ii(0x1016_e864, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_e866, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1016_e868, 3); mov(dl, memb_a32[ss, ebp + 0]);         /* mov dl, [ebp] */
            ii(0x1016_e86b, 2); add(ecx, esi);                          /* add ecx, esi */
            ii(0x1016_e86d, 3); cmp(dl, 0x40);                          /* cmp dl, 0x40 */
            ii(0x1016_e870, 2); if(jnzd(0x1016_e892, 0x20)) goto l_0x1016_e892; /* jnz 0x1016e892 */
            ii(0x1016_e872, 2); mov(edi, esp);                          /* mov edi, esp */
            ii(0x1016_e874, 2); add(esi, ebp);                          /* add esi, ebp */
            ii(0x1016_e876, 1); pushd(edi);                             /* push edi */
        l_0x1016_e877:
            ii(0x1016_e877, 2); mov(al, memb_a32[ds, esi]);             /* mov al, [esi] */
            ii(0x1016_e879, 2); mov(memb_a32[ds, edi], al);             /* mov [edi], al */
            ii(0x1016_e87b, 2); cmp(al, 0);                             /* cmp al, 0x0 */
            ii(0x1016_e87d, 2); if(jzd(0x1016_e88f, 0x10)) goto l_0x1016_e88f; /* jz 0x1016e88f */
            ii(0x1016_e87f, 3); mov(al, memb_a32[ds, esi + 0x1]);       /* mov al, [esi+0x1] */
            ii(0x1016_e882, 3); add(esi, 0x2);                          /* add esi, 0x2 */
            ii(0x1016_e885, 3); mov(memb_a32[ds, edi + 0x1], al);       /* mov [edi+0x1], al */
            ii(0x1016_e888, 3); add(edi, 0x2);                          /* add edi, 0x2 */
            ii(0x1016_e88b, 2); cmp(al, 0);                             /* cmp al, 0x0 */
            ii(0x1016_e88d, 2); if(jnzd(0x1016_e877, -0x18)) goto l_0x1016_e877; /* jnz 0x1016e877 */
        l_0x1016_e88f:
            ii(0x1016_e88f, 1); popd(edi);                              /* pop edi */
            ii(0x1016_e890, 2); xor(esi, esi);                          /* xor esi, esi */
        l_0x1016_e892:
            ii(0x1016_e892, 5); mov(eax, memd_a32[ds, 0x101b_e1c0]);    /* mov eax, [0x101be1c0] */
            ii(0x1016_e897, 3); mov(edi, memd_a32[ds, eax + 0xc]);      /* mov edi, [eax+0xc] */
            ii(0x1016_e89a, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1016_e89c, 2); if(jzd(0x1016_e8db, 0x3d)) goto l_0x1016_e8db; /* jz 0x1016e8db */
            ii(0x1016_e89e, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1016_e8a0, 2); if(jzd(0x1016_e8b6, 0x14)) goto l_0x1016_e8b6; /* jz 0x1016e8b6 */
            ii(0x1016_e8a2, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_e8a3, 1); pushd(edi);                             /* push edi */
            ii(0x1016_e8a4, 5); pushd(StringDefinitions.SS);            /* push 0x101b2ed0 */
            ii(0x1016_e8a9, 4); lea(eax, esp + 0xc);                    /* lea eax, [esp+0xc] */
            ii(0x1016_e8ad, 1); pushd(eax);                             /* push eax */
            ii(0x1016_e8ae, 5); calld(Definitions.sys_sprintf, -0x89b2); /* call 0x10165f01 */
            ii(0x1016_e8b3, 3); add(esp, 0x10);                         /* add esp, 0x10 */
        l_0x1016_e8b6:
            ii(0x1016_e8b6, 7); mov(edx, memd_a32[ss, esp + 0xa0]);     /* mov edx, [esp+0xa0] */
            ii(0x1016_e8bd, 2); mov(eax, esp);                          /* mov eax, esp */
            ii(0x1016_e8bf, 5); calld(Definitions.sys_fopen, 0x3ab6);   /* call 0x1017237a */
            ii(0x1016_e8c4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_e8c6, 2); if(jzd(0x1016_e8db, 0x13)) goto l_0x1016_e8db; /* jz 0x1016e8db */
            ii(0x1016_e8c8, 3); or(cl, 0x4);                            /* or cl, 0x4 */
            ii(0x1016_e8cb, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_e8cd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_e8cf, 5); calld(/* sys */ 0x1017_0d58, 0x2484);   /* call 0x10170d58 */
            ii(0x1016_e8d4, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1016_e8d6, 5); jmpd(0x1016_ea5d, 0x182); goto l_0x1016_ea5d; /* jmp 0x1016ea5d */
        l_0x1016_e8db:
            ii(0x1016_e8db, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1016_e8dd, 6); if(jzd(0x1016_ea5b, 0x178)) goto l_0x1016_ea5b; /* jz 0x1016ea5b */
            ii(0x1016_e8e3, 5); mov(eax, memd_a32[ds, 0x101b_e1c0]);    /* mov eax, [0x101be1c0] */
            ii(0x1016_e8e8, 3); cmp(memd_a32[ds, eax], 0);              /* cmp dword [eax], 0x0 */
            ii(0x1016_e8eb, 6); if(jzd(0x1016_ea5b, 0x16a)) goto l_0x1016_ea5b; /* jz 0x1016ea5b */
            ii(0x1016_e8f1, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1016_e8f3, 2); if(jzd(0x1016_e90c, 0x17)) goto l_0x1016_e90c; /* jz 0x1016e90c */
            ii(0x1016_e8f5, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_e8f6, 3); mov(esi, memd_a32[ds, eax + 0x8]);      /* mov esi, [eax+0x8] */
            ii(0x1016_e8f9, 1); pushd(esi);                             /* push esi */
            ii(0x1016_e8fa, 5); pushd(StringDefinitions.SS);            /* push 0x101b2ed0 */
            ii(0x1016_e8ff, 4); lea(eax, esp + 0xc);                    /* lea eax, [esp+0xc] */
            ii(0x1016_e903, 1); pushd(eax);                             /* push eax */
            ii(0x1016_e904, 5); calld(Definitions.sys_sprintf, -0x8a08); /* call 0x10165f01 */
            ii(0x1016_e909, 3); add(esp, 0x10);                         /* add esp, 0x10 */
        l_0x1016_e90c:
            ii(0x1016_e90c, 2); mov(eax, esp);                          /* mov eax, esp */
            ii(0x1016_e90e, 7); lea(edx, esp + 0x90);                   /* lea edx, [esp+0x90] */
            ii(0x1016_e915, 5); calld(/* sys */ 0x1017_9342, 0xaa28);   /* call 0x10179342 */
            ii(0x1016_e91a, 2); mov(eax, esp);                          /* mov eax, esp */
            ii(0x1016_e91c, 5); calld(/* sys */ 0x1017_1028, 0x2707);   /* call 0x10171028 */
            ii(0x1016_e921, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1016_e924, 6); if(jzd(0x1016_ea5b, 0x131)) goto l_0x1016_ea5b; /* jz 0x1016ea5b */
            ii(0x1016_e92a, 5); mov(eax, memd_a32[ds, 0x101b_e1c0]);    /* mov eax, [0x101be1c0] */
            ii(0x1016_e92f, 3); mov(edi, memd_a32[ds, eax + 0x4]);      /* mov edi, [eax+0x4] */
            ii(0x1016_e932, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1016_e934, 6); if(jzd(0x1016_ea5b, 0x121)) goto l_0x1016_ea5b; /* jz 0x1016ea5b */
            ii(0x1016_e93a, 7); mov(edx, memd_a32[ss, esp + 0x94]);     /* mov edx, [esp+0x94] */
            ii(0x1016_e941, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1016_e943, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_e945, 5); calld(Definitions.sys_fseek, 0x3b26);   /* call 0x10172470 */
            ii(0x1016_e94a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_e94c, 6); if(jnzd(0x1016_ea5b, 0x109)) goto l_0x1016_ea5b; /* jnz 0x1016ea5b */
            ii(0x1016_e952, 8); cmp(memd_a32[ss, esp + 0x90], 0);       /* cmp dword [esp+0x90], 0x0 */
            ii(0x1016_e95a, 2); if(jnzd(0x1016_e967, 0xb)) goto l_0x1016_e967; /* jnz 0x1016e967 */
            ii(0x1016_e95c, 11); mov(memd_a32[ss, esp + 0x90], 0x10);   /* mov dword [esp+0x90], 0x10 */
        l_0x1016_e967:
            ii(0x1016_e967, 7); mov(eax, memd_a32[ss, esp + 0x90]);     /* mov eax, [esp+0x90] */
            ii(0x1016_e96e, 5); and(eax, 0xf0);                         /* and eax, 0xf0 */
            ii(0x1016_e973, 3); cmp(eax, 0x20);                         /* cmp eax, 0x20 */
            ii(0x1016_e976, 2); if(jbd(0x1016_e988, 0x10)) goto l_0x1016_e988; /* jb 0x1016e988 */
            ii(0x1016_e978, 2); if(jbed(0x1016_e9ec, 0x72)) goto l_0x1016_e9ec; /* jbe 0x1016e9ec */
            ii(0x1016_e97a, 3); cmp(eax, 0x40);                         /* cmp eax, 0x40 */
            ii(0x1016_e97d, 6); if(jzd(0x1016_ea15, 0x92)) goto l_0x1016_ea15; /* jz 0x1016ea15 */
            ii(0x1016_e983, 5); jmpd(0x1016_ea5b, 0xd3); goto l_0x1016_ea5b; /* jmp 0x1016ea5b */
        l_0x1016_e988:
            ii(0x1016_e988, 3); cmp(eax, 0x10);                         /* cmp eax, 0x10 */
            ii(0x1016_e98b, 6); if(jnzd(0x1016_ea5b, 0xca)) goto l_0x1016_ea5b; /* jnz 0x1016ea5b */
            ii(0x1016_e991, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1016_e996, 7); mov(eax, memd_a32[ss, esp + 0x98]);     /* mov eax, [esp+0x98] */
            ii(0x1016_e99d, 6); mov(memd_a32[ds, 0x101b_e1c4], ebx);    /* mov [0x101be1c4], ebx */
            ii(0x1016_e9a3, 6); calld_abs(memd_a32[ds, 0x101b_e1c8]);   /* call dword [0x101be1c8] */ /* Вызов '0x1017_11a4'. */
            ii(0x1016_e9a9, 2); mov(ebp, eax);                          /* mov ebp, eax */
            ii(0x1016_e9ab, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_e9ad, 6); if(jzd(0x1016_ea5b, 0xa8)) goto l_0x1016_ea5b; /* jz 0x1016ea5b */
            ii(0x1016_e9b3, 5); mov(eax, memd_a32[ds, 0x101b_e1c0]);    /* mov eax, [0x101be1c0] */
            ii(0x1016_e9b8, 7); mov(ebx, memd_a32[ss, esp + 0x9c]);     /* mov ebx, [esp+0x9c] */
            ii(0x1016_e9bf, 2); mov(edx, ebp);                          /* mov edx, ebp */
            ii(0x1016_e9c1, 3); mov(eax, memd_a32[ds, eax + 0x4]);      /* mov eax, [eax+0x4] */
            ii(0x1016_e9c4, 3); or(cl, 0x18);                           /* or cl, 0x18 */
            ii(0x1016_e9c7, 5); calld(/* sys */ 0x1018_7f50, 0x1_9584); /* call 0x10187f50 */
            ii(0x1016_e9cc, 7); mov(ebx, memd_a32[ss, esp + 0x98]);     /* mov ebx, [esp+0x98] */
            ii(0x1016_e9d3, 2); mov(edx, ebp);                          /* mov edx, ebp */
            ii(0x1016_e9d5, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_e9d7, 5); calld(/* sys */ 0x1017_0d58, 0x237c);   /* call 0x10170d58 */
            ii(0x1016_e9dc, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1016_e9de, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_e9e0, 6); add(esp, 0xa4);                         /* add esp, 0xa4 */
            ii(0x1016_e9e6, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_e9e7, 1); popd(edi);                              /* pop edi */
            ii(0x1016_e9e8, 1); popd(esi);                              /* pop esi */
            ii(0x1016_e9e9, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_e9ea, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_e9eb, 1); retd(); return;                         /* ret */
        l_0x1016_e9ec:
            ii(0x1016_e9ec, 7); mov(ebx, memd_a32[ss, esp + 0x98]);     /* mov ebx, [esp+0x98] */
            ii(0x1016_e9f3, 5); mov(eax, memd_a32[ds, 0x101b_e1c0]);    /* mov eax, [0x101be1c0] */
            ii(0x1016_e9f8, 3); or(cl, 0x28);                           /* or cl, 0x28 */
            ii(0x1016_e9fb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_e9fd, 3); mov(eax, memd_a32[ds, eax + 0x4]);      /* mov eax, [eax+0x4] */
            ii(0x1016_ea00, 5); calld(/* sys */ 0x1017_0d58, 0x2353);   /* call 0x10170d58 */
            ii(0x1016_ea05, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1016_ea07, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_ea09, 6); add(esp, 0xa4);                         /* add esp, 0xa4 */
            ii(0x1016_ea0f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_ea10, 1); popd(edi);                              /* pop edi */
            ii(0x1016_ea11, 1); popd(esi);                              /* pop esi */
            ii(0x1016_ea12, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_ea13, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_ea14, 1); retd(); return;                         /* ret */
        l_0x1016_ea15:
            ii(0x1016_ea15, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1016_ea1a, 5); mov(eax, 0x4000);                       /* mov eax, 0x4000 */
            ii(0x1016_ea1f, 6); mov(memd_a32[ds, 0x101b_e1c4], edx);    /* mov [0x101be1c4], edx */
            ii(0x1016_ea25, 6); calld_abs(memd_a32[ds, 0x101b_e1c8]);   /* call dword [0x101be1c8] */ /* Вызов '0x1017_11a4'. */
            ii(0x1016_ea2b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_ea2d, 2); if(jzd(0x1016_ea5b, 0x2c)) goto l_0x1016_ea5b; /* jz 0x1016ea5b */
            ii(0x1016_ea2f, 6); mov(esi, memd_a32[ds, 0x101b_e1c0]);    /* mov esi, [0x101be1c0] */
            ii(0x1016_ea35, 7); mov(ebx, memd_a32[ss, esp + 0x98]);     /* mov ebx, [esp+0x98] */
            ii(0x1016_ea3c, 3); or(cl, 0x48);                           /* or cl, 0x48 */
            ii(0x1016_ea3f, 3); mov(esi, memd_a32[ds, esi + 0x4]);      /* mov esi, [esi+0x4] */
            ii(0x1016_ea42, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_ea44, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_ea46, 5); calld(/* sys */ 0x1017_0d58, 0x230d);   /* call 0x10170d58 */
            ii(0x1016_ea4b, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1016_ea4d, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_ea4f, 6); add(esp, 0xa4);                         /* add esp, 0xa4 */
            ii(0x1016_ea55, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_ea56, 1); popd(edi);                              /* pop edi */
            ii(0x1016_ea57, 1); popd(esi);                              /* pop esi */
            ii(0x1016_ea58, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_ea59, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_ea5a, 1); retd(); return;                         /* ret */
        l_0x1016_ea5b:
            ii(0x1016_ea5b, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
        l_0x1016_ea5d:
            ii(0x1016_ea5d, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_ea5f, 6); add(esp, 0xa4);                         /* add esp, 0xa4 */
            ii(0x1016_ea65, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_ea66, 1); popd(edi);                              /* pop edi */
            ii(0x1016_ea67, 1); popd(esi);                              /* pop esi */
            ii(0x1016_ea68, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_ea69, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_ea6a, 1); retd();                                 /* ret */
        }
    }
}
