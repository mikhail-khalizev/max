using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_7177-27b33a79")]
        public void Method_100c_7177()
        {
            ii(0x100c_7177, 5); push(0x44);                             /* push 0x44 */
            ii(0x100c_717c, 5); call(Definitions.sys_check_available_stack_size, 0x9_ebd1); /* call 0x10165d52 */
            ii(0x100c_7181, 1); push(ebx);                              /* push ebx */
            ii(0x100c_7182, 1); push(ecx);                              /* push ecx */
            ii(0x100c_7183, 1); push(esi);                              /* push esi */
            ii(0x100c_7184, 1); push(edi);                              /* push edi */
            ii(0x100c_7185, 1); push(ebp);                              /* push ebp */
            ii(0x100c_7186, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_7188, 6); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x100c_718e, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_7191, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100c_7194, 4); or(memb[ss, ebp - 12], 1);              /* or byte [ebp-0xc], 0x1 */
            ii(0x100c_7198, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x100c_719b, 5); call(0x100c_a02c, 0x2e8c);              /* call 0x100ca02c */
            ii(0x100c_71a0, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x100c_71a3, 4); and(memb[ss, ebp - 12], -2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x100c_71a7, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100c_71ac, 5); call(0x1007_6338, -0x5_0e79);           /* call 0x10076338 */
            ii(0x100c_71b1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_71b3, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x100c_71b6, 5); call(0x1007_64b8, -0x5_0d03);           /* call 0x100764b8 */
            ii(0x100c_71bb, 2); jmp(0x100c_71c5, 8); goto l_0x100c_71c5; /* jmp 0x100c71c5 */
        l_0x100c_71bd:
            ii(0x100c_71bd, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x100c_71c0, 5); call(0x1007_6bf8, -0x5_05cd);           /* call 0x10076bf8 */
        l_0x100c_71c5:
            ii(0x100c_71c5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_71c7, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x100c_71ca, 5); call(0x1013_ad71, 0x7_3ba2);            /* call 0x1013ad71 */
            ii(0x100c_71cf, 2); test(al, al);                           /* test al, al */
            ii(0x100c_71d1, 6); if(jz(0x100c_7250, 0x79)) goto l_0x100c_7250; /* jz 0x100c7250 */
            ii(0x100c_71d7, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x100c_71da, 5); call(0x1007_63a0, -0x5_0e3f);           /* call 0x100763a0 */
            ii(0x100c_71df, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_71e1, 3); mov(dl, memb[ds, eax + 38]);            /* mov dl, [eax+0x26] */
            ii(0x100c_71e4, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_71e7, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100c_71ea, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_71ec, 2); if(jnz(0x100c_71fc, 0xe)) goto l_0x100c_71fc; /* jnz 0x100c71fc */
            ii(0x100c_71ee, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x100c_71f1, 5); call(0x1007_63a0, -0x5_0e56);           /* call 0x100763a0 */
            ii(0x100c_71f6, 4); cmp(memb[ds, eax + 61], 4);             /* cmp byte [eax+0x3d], 0x4 */
            ii(0x100c_71fa, 2); if(jz(0x100c_71fe, 2)) goto l_0x100c_71fe; /* jz 0x100c71fe */
        l_0x100c_71fc:
            ii(0x100c_71fc, 2); jmp(0x100c_720c, 0xe); goto l_0x100c_720c; /* jmp 0x100c720c */
        l_0x100c_71fe:
            ii(0x100c_71fe, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x100c_7201, 5); call(0x1007_63a0, -0x5_0e66);           /* call 0x100763a0 */
            ii(0x100c_7206, 4); cmp(memb[ds, eax + 62], 0x1f);          /* cmp byte [eax+0x3e], 0x1f */
            ii(0x100c_720a, 2); if(jnz(0x100c_720e, 2)) goto l_0x100c_720e; /* jnz 0x100c720e */
        l_0x100c_720c:
            ii(0x100c_720c, 2); jmp(0x100c_722e, 0x20); goto l_0x100c_722e; /* jmp 0x100c722e */
        l_0x100c_720e:
            ii(0x100c_720e, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x100c_7211, 5); call(0x1007_63a0, -0x5_0e76);           /* call 0x100763a0 */
            ii(0x100c_7216, 5); call(0x1015_0a9e, 0x8_9883);            /* call 0x10150a9e */
            ii(0x100c_721b, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x100c_721e, 3); lea(edx, memd[ss, ebp - 32]);           /* lea edx, [ebp-0x20] */
            ii(0x100c_7221, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x100c_7224, 5); call(0x1008_b268, -0x3_bfc1);           /* call 0x1008b268 */
            ii(0x100c_7229, 1); cwde();                                 /* cwde */
            ii(0x100c_722a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_722c, 2); if(jl(0x100c_7230, 2)) goto l_0x100c_7230; /* jl 0x100c7230 */
        l_0x100c_722e:
            ii(0x100c_722e, 2); jmp(0x100c_724b, 0x1b); goto l_0x100c_724b; /* jmp 0x100c724b */
        l_0x100c_7230:
            ii(0x100c_7230, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x100c_7233, 5); call(0x1007_63a0, -0x5_0e98);           /* call 0x100763a0 */
            ii(0x100c_7238, 5); call(0x1015_0a9e, 0x8_9861);            /* call 0x10150a9e */
            ii(0x100c_723d, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
            ii(0x100c_7240, 3); lea(edx, memd[ss, ebp - 36]);           /* lea edx, [ebp-0x24] */
            ii(0x100c_7243, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x100c_7246, 5); call(0x1008_b2a8, -0x3_bfa3);           /* call 0x1008b2a8 */
        l_0x100c_724b:
            ii(0x100c_724b, 5); jmp(0x100c_71bd, -0x93); goto l_0x100c_71bd; /* jmp 0x100c71bd */
        l_0x100c_7250:
            ii(0x100c_7250, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100c_7255, 5); call(0x1007_6338, -0x5_0f22);           /* call 0x10076338 */
            ii(0x100c_725a, 3); lea(ebx, memd[ss, ebp - 20]);           /* lea ebx, [ebp-0x14] */
            ii(0x100c_725d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_725f, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100c_7261, 5); call(0x1007_643c, -0x5_0e2a);           /* call 0x1007643c */
            ii(0x100c_7266, 2); jmp(0x100c_7270, 8); goto l_0x100c_7270; /* jmp 0x100c7270 */
        l_0x100c_7268:
            ii(0x100c_7268, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x100c_726b, 5); call(0x1007_6bf8, -0x5_0678);           /* call 0x10076bf8 */
        l_0x100c_7270:
            ii(0x100c_7270, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_7272, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x100c_7275, 5); call(0x1013_ad71, 0x7_3af7);            /* call 0x1013ad71 */
            ii(0x100c_727a, 2); test(al, al);                           /* test al, al */
            ii(0x100c_727c, 6); if(jz(0x100c_72fb, 0x79)) goto l_0x100c_72fb; /* jz 0x100c72fb */
            ii(0x100c_7282, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x100c_7285, 5); call(0x1007_63a0, -0x5_0eea);           /* call 0x100763a0 */
            ii(0x100c_728a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_728c, 3); mov(dl, memb[ds, eax + 38]);            /* mov dl, [eax+0x26] */
            ii(0x100c_728f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_7292, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100c_7295, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_7297, 2); if(jnz(0x100c_72a7, 0xe)) goto l_0x100c_72a7; /* jnz 0x100c72a7 */
            ii(0x100c_7299, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x100c_729c, 5); call(0x1007_63a0, -0x5_0f01);           /* call 0x100763a0 */
            ii(0x100c_72a1, 4); cmp(memb[ds, eax + 61], 4);             /* cmp byte [eax+0x3d], 0x4 */
            ii(0x100c_72a5, 2); if(jz(0x100c_72a9, 2)) goto l_0x100c_72a9; /* jz 0x100c72a9 */
        l_0x100c_72a7:
            ii(0x100c_72a7, 2); jmp(0x100c_72b7, 0xe); goto l_0x100c_72b7; /* jmp 0x100c72b7 */
        l_0x100c_72a9:
            ii(0x100c_72a9, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x100c_72ac, 5); call(0x1007_63a0, -0x5_0f11);           /* call 0x100763a0 */
            ii(0x100c_72b1, 4); cmp(memb[ds, eax + 62], 0x1f);          /* cmp byte [eax+0x3e], 0x1f */
            ii(0x100c_72b5, 2); if(jnz(0x100c_72b9, 2)) goto l_0x100c_72b9; /* jnz 0x100c72b9 */
        l_0x100c_72b7:
            ii(0x100c_72b7, 2); jmp(0x100c_72d9, 0x20); goto l_0x100c_72d9; /* jmp 0x100c72d9 */
        l_0x100c_72b9:
            ii(0x100c_72b9, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x100c_72bc, 5); call(0x1007_63a0, -0x5_0f21);           /* call 0x100763a0 */
            ii(0x100c_72c1, 5); call(0x1015_0a9e, 0x8_97d8);            /* call 0x10150a9e */
            ii(0x100c_72c6, 3); mov(memd[ss, ebp - 40], eax);           /* mov [ebp-0x28], eax */
            ii(0x100c_72c9, 3); lea(edx, memd[ss, ebp - 40]);           /* lea edx, [ebp-0x28] */
            ii(0x100c_72cc, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x100c_72cf, 5); call(0x1008_b268, -0x3_c06c);           /* call 0x1008b268 */
            ii(0x100c_72d4, 1); cwde();                                 /* cwde */
            ii(0x100c_72d5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_72d7, 2); if(jl(0x100c_72db, 2)) goto l_0x100c_72db; /* jl 0x100c72db */
        l_0x100c_72d9:
            ii(0x100c_72d9, 2); jmp(0x100c_72f6, 0x1b); goto l_0x100c_72f6; /* jmp 0x100c72f6 */
        l_0x100c_72db:
            ii(0x100c_72db, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x100c_72de, 5); call(0x1007_63a0, -0x5_0f43);           /* call 0x100763a0 */
            ii(0x100c_72e3, 5); call(0x1015_0a9e, 0x8_97b6);            /* call 0x10150a9e */
            ii(0x100c_72e8, 3); mov(memd[ss, ebp - 44], eax);           /* mov [ebp-0x2c], eax */
            ii(0x100c_72eb, 3); lea(edx, memd[ss, ebp - 44]);           /* lea edx, [ebp-0x2c] */
            ii(0x100c_72ee, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x100c_72f1, 5); call(0x1008_b2a8, -0x3_c04e);           /* call 0x1008b2a8 */
        l_0x100c_72f6:
            ii(0x100c_72f6, 5); jmp(0x100c_7268, -0x93); goto l_0x100c_7268; /* jmp 0x100c7268 */
        l_0x100c_72fb:
            ii(0x100c_72fb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_72fe, 5); call(0x100c_ae28, 0x3b25);              /* call 0x100cae28 */
            ii(0x100c_7303, 1); dec(eax);                               /* dec eax */
            ii(0x100c_7304, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x100c_7307, 2); jmp(0x100c_730f, 6); goto l_0x100c_730f; /* jmp 0x100c730f */
        l_0x100c_7309:
            ii(0x100c_7309, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100c_730c, 3); dec(memd[ss, ebp - 16]);                /* dec dword [ebp-0x10] */
        l_0x100c_730f:
            ii(0x100c_730f, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x100c_7313, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_7315, 2); if(jl(0x100c_7341, 0x2a)) goto l_0x100c_7341; /* jl 0x100c7341 */
            ii(0x100c_7317, 4); movsx(edx, memw[ss, ebp - 16]);         /* movsx edx, word [ebp-0x10] */
            ii(0x100c_731b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_731e, 5); call(0x100c_acf0, 0x39cd);              /* call 0x100cacf0 */
            ii(0x100c_7323, 3); lea(edx, memd[ds, eax + 1]);            /* lea edx, [eax+0x1] */
            ii(0x100c_7326, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x100c_7329, 5); call(0x1008_b268, -0x3_c0c6);           /* call 0x1008b268 */
            ii(0x100c_732e, 1); cwde();                                 /* cwde */
            ii(0x100c_732f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_7331, 2); if(jge(0x100c_733f, 0xc)) goto l_0x100c_733f; /* jge 0x100c733f */
            ii(0x100c_7333, 4); movsx(edx, memw[ss, ebp - 16]);         /* movsx edx, word [ebp-0x10] */
            ii(0x100c_7337, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_733a, 5); call(0x100c_adec, 0x3aad);              /* call 0x100cadec */
        l_0x100c_733f:
            ii(0x100c_733f, 2); jmp(0x100c_7309, -0x38); goto l_0x100c_7309; /* jmp 0x100c7309 */
        l_0x100c_7341:
            ii(0x100c_7341, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_7343, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x100c_7346, 5); call(0x1007_5f6c, -0x5_13df);           /* call 0x10075f6c */
            ii(0x100c_734b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_734d, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x100c_7350, 5); call(0x1008_8b04, -0x3_e851);           /* call 0x10088b04 */
            ii(0x100c_7355, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_7357, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_7358, 1); pop(edi);                               /* pop edi */
            ii(0x100c_7359, 1); pop(esi);                               /* pop esi */
            ii(0x100c_735a, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_735b, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_735c, 1); ret();                                  /* ret */
        }
    }
}
