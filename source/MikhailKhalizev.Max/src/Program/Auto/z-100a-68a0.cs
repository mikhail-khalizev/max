using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_68a0-f0919d")]
        public void Method_100a_68a0()
        {
            ii(0x100a_68a0, 5); push(0xa4);                             /* push 0xa4 */
            ii(0x100a_68a5, 5); call(Definitions.sys_check_available_stack_size, 0xb_f4a8); /* call 0x10165d52 */
            ii(0x100a_68aa, 1); push(ebx);                              /* push ebx */
            ii(0x100a_68ab, 1); push(ecx);                              /* push ecx */
            ii(0x100a_68ac, 1); push(edx);                              /* push edx */
            ii(0x100a_68ad, 1); push(esi);                              /* push esi */
            ii(0x100a_68ae, 1); push(edi);                              /* push edi */
            ii(0x100a_68af, 1); push(ebp);                              /* push ebp */
            ii(0x100a_68b0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_68b2, 6); sub(esp, 0x84);                         /* sub esp, 0x84 */
            ii(0x100a_68b8, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100a_68bb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_68bd, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_68c0, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100a_68c3, 5); call(0x1013_ad11, 0x9_4449);            /* call 0x1013ad11 */
            ii(0x100a_68c8, 2); test(al, al);                           /* test al, al */
            ii(0x100a_68ca, 2); if(jnz(0x100a_68ea, 0x1e)) goto l_0x100a_68ea; /* jnz 0x100a68ea */
            ii(0x100a_68cc, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_68cf, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100a_68d2, 5); call(0x1008_af28, -0x1_b9af);           /* call 0x1008af28 */
            ii(0x100a_68d7, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_68da, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_68dd, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x100a_68e0, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_68e3, 3); call_abs(memd[ds, edx + 0x24]);         /* call dword [edx+0x24] */
            ii(0x100a_68e6, 2); test(al, al);                           /* test al, al */
            ii(0x100a_68e8, 2); if(jnz(0x100a_68f5, 0xb)) goto l_0x100a_68f5; /* jnz 0x100a68f5 */
        l_0x100a_68ea:
            ii(0x100a_68ea, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_68ed, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_68f0, 5); call(0x1009_caf8, -0x9dfd);             /* call 0x1009caf8 */
        l_0x100a_68f5:
            ii(0x100a_68f5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_68f8, 4); cmp(memb[ds, eax + 0x1b], 0);           /* cmp byte [eax+0x1b], 0x0 */
            ii(0x100a_68fc, 6); if(jz(0x100a_6b25, 0x223)) goto l_0x100a_6b25; /* jz 0x100a6b25 */
            ii(0x100a_6902, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_6905, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_6908, 5); call(Definitions.my_2_get_count, -0x1_b5a5); /* call 0x1008b368 */
            ii(0x100a_690d, 1); dec(eax);                               /* dec eax */
            ii(0x100a_690e, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_6911, 2); jmp(0x100a_6919, 6); goto l_0x100a_6919; /* jmp 0x100a6919 */
        l_0x100a_6913:
            ii(0x100a_6913, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_6916, 3); dec(memd[ss, ebp - 8]);                 /* dec dword [ebp-0x8] */
        l_0x100a_6919:
            ii(0x100a_6919, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100a_691d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_691f, 6); if(jl(0x100a_69a7, 0x82)) goto l_0x100a_69a7; /* jl 0x100a69a7 */
            ii(0x100a_6925, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100a_6927, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x100a_692b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_692e, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_6931, 5); call(0x1008_b228, -0x1_b70e);           /* call 0x1008b228 */
            ii(0x100a_6936, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x100a_6939, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_693c, 5); call(0x100a_65f4, -0x34d);              /* call 0x100a65f4 */
            ii(0x100a_6941, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_6944, 4); cmp(memd[ss, ebp - 0x10], 0);           /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100a_6948, 2); if(jz(0x100a_69a2, 0x58)) goto l_0x100a_69a2; /* jz 0x100a69a2 */
            ii(0x100a_694a, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x100a_694e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_6951, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_6954, 5); call(0x1008_b32c, -0x1_b62d);           /* call 0x1008b32c */
            ii(0x100a_6959, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_695c, 5); call(0x1015_26ac, 0xa_bd4b);            /* call 0x101526ac */
            ii(0x100a_6961, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_6963, 2); if(jz(0x100a_6985, 0x20)) goto l_0x100a_6985; /* jz 0x100a6985 */
            ii(0x100a_6965, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_6968, 5); call(0x1015_287d, 0xa_bf10);            /* call 0x1015287d */
            ii(0x100a_696d, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_6970, 4); cmp(memb[ds, eax + 0x3d], 0);           /* cmp byte [eax+0x3d], 0x0 */
            ii(0x100a_6974, 2); if(jz(0x100a_6985, 0xf)) goto l_0x100a_6985; /* jz 0x100a6985 */
            ii(0x100a_6976, 5); mov(ebx, 0x18);                         /* mov ebx, 0x18 */
            ii(0x100a_697b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_697d, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_6980, 5); call(0x1016_3053, 0xb_c6ce);            /* call 0x10163053 */
        l_0x100a_6985:
            ii(0x100a_6985, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_6988, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100a_698b, 5); call(0x1008_af28, -0x1_ba68);           /* call 0x1008af28 */
            ii(0x100a_6990, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100a_6993, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100a_6996, 3); mov(ebx, memd[ds, eax + 2]);            /* mov ebx, [eax+0x2] */
            ii(0x100a_6999, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x100a_699c, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100a_699f, 3); call_abs(memd[ds, ebx + 0x2c]);         /* call dword [ebx+0x2c] */
        l_0x100a_69a2:
            ii(0x100a_69a2, 5); jmp(0x100a_6913, -0x94); goto l_0x100a_6913; /* jmp 0x100a6913 */
        l_0x100a_69a7:
            ii(0x100a_69a7, 5); mov(ebx, 0x5d);                         /* mov ebx, 0x5d */
            ii(0x100a_69ac, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_69ae, 3); lea(eax, memd[ss, ebp - 0x74]);         /* lea eax, [ebp-0x74] */
            ii(0x100a_69b1, 5); call(Definitions.sys_memset, 0xb_f42a); /* call 0x10165de0 */
            ii(0x100a_69b6, 7); mov(memd[ss, ebp - 8], 0);              /* mov dword [ebp-0x8], 0x0 */
            ii(0x100a_69bd, 2); jmp(0x100a_69c5, 6); goto l_0x100a_69c5; /* jmp 0x100a69c5 */
        l_0x100a_69bf:
            ii(0x100a_69bf, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_69c2, 3); inc(memd[ss, ebp - 8]);                 /* inc dword [ebp-0x8] */
        l_0x100a_69c5:
            ii(0x100a_69c5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_69c8, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_69cb, 5); call(Definitions.my_2_get_count, -0x1_b668); /* call 0x1008b368 */
            ii(0x100a_69d0, 4); cmp(ax, memw[ss, ebp - 8]);             /* cmp ax, [ebp-0x8] */
            ii(0x100a_69d4, 6); if(jle(0x100a_6b1e, 0x144)) goto l_0x100a_6b1e; /* jle 0x100a6b1e */
            ii(0x100a_69da, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x100a_69de, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_69e1, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_69e4, 5); call(0x1008_b228, -0x1_b7c1);           /* call 0x1008b228 */
            ii(0x100a_69e9, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100a_69ec, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100a_69ef, 7); test(memb[ds, eax + 0x101c_81c1], 2);   /* test byte [eax+0x101c81c1], 0x2 */
            ii(0x100a_69f6, 2); if(jz(0x100a_6a36, 0x3e)) goto l_0x100a_6a36; /* jz 0x100a6a36 */
            ii(0x100a_69f8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_69fb, 1); push(eax);                              /* push eax */
            ii(0x100a_69fc, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_69ff, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x100a_6a02, 3); lea(eax, memd[ss, ebp - 0x78]);         /* lea eax, [ebp-0x78] */
            ii(0x100a_6a05, 5); call(0x1007_5e64, -0x3_0ba6);           /* call 0x10075e64 */
            ii(0x100a_6a0a, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100a_6a0c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_6a0f, 3); mov(ebx, memd[ds, eax + 7]);            /* mov ebx, [eax+0x7] */
            ii(0x100a_6a12, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100a_6a15, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x100a_6a19, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_6a1c, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_6a1f, 5); call(0x1008_b228, -0x1_b7fc);           /* call 0x1008b228 */
            ii(0x100a_6a24, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x100a_6a27, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_6a2c, 5); call(0x100a_4954, -0x20dd);             /* call 0x100a4954 */
            ii(0x100a_6a31, 5); jmp(0x100a_6b19, 0xe3); goto l_0x100a_6b19; /* jmp 0x100a6b19 */
        l_0x100a_6a36:
            ii(0x100a_6a36, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x100a_6a3a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_6a3d, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_6a40, 5); call(0x1008_b228, -0x1_b81d);           /* call 0x1008b228 */
            ii(0x100a_6a45, 4); cmp(memw[ds, eax], 0x31);               /* cmp word [eax], 0x31 */
            ii(0x100a_6a49, 2); if(jz(0x100a_6a60, 0x15)) goto l_0x100a_6a60; /* jz 0x100a6a60 */
            ii(0x100a_6a4b, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x100a_6a4f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_6a52, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_6a55, 5); call(0x1008_b228, -0x1_b832);           /* call 0x1008b228 */
            ii(0x100a_6a5a, 4); cmp(memw[ds, eax], 0x3d);               /* cmp word [eax], 0x3d */
            ii(0x100a_6a5e, 2); if(jnz(0x100a_6a9e, 0x3e)) goto l_0x100a_6a9e; /* jnz 0x100a6a9e */
        l_0x100a_6a60:
            ii(0x100a_6a60, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_6a63, 1); push(eax);                              /* push eax */
            ii(0x100a_6a64, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_6a67, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x100a_6a6a, 3); lea(eax, memd[ss, ebp - 0x7c]);         /* lea eax, [ebp-0x7c] */
            ii(0x100a_6a6d, 5); call(0x1007_5e64, -0x3_0c0e);           /* call 0x10075e64 */
            ii(0x100a_6a72, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100a_6a74, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_6a77, 3); mov(ebx, memd[ds, eax + 7]);            /* mov ebx, [eax+0x7] */
            ii(0x100a_6a7a, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100a_6a7d, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x100a_6a81, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_6a84, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_6a87, 5); call(0x1008_b228, -0x1_b864);           /* call 0x1008b228 */
            ii(0x100a_6a8c, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x100a_6a8f, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_6a94, 5); call(0x100a_49d0, -0x20c9);             /* call 0x100a49d0 */
            ii(0x100a_6a99, 5); jmp(0x100a_6b19, 0x7b); goto l_0x100a_6b19; /* jmp 0x100a6b19 */
        l_0x100a_6a9e:
            ii(0x100a_6a9e, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x100a_6aa2, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_6aa5, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_6aa8, 5); call(0x1008_b228, -0x1_b885);           /* call 0x1008b228 */
            ii(0x100a_6aad, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100a_6ab0, 5); cmp(memb[ds, eax + ebp - 0x74], 0);     /* cmp byte [eax+ebp-0x74], 0x0 */
            ii(0x100a_6ab5, 2); if(jnz(0x100a_6b19, 0x62)) goto l_0x100a_6b19; /* jnz 0x100a6b19 */
            ii(0x100a_6ab7, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x100a_6abb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_6abe, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_6ac1, 5); call(0x1008_b228, -0x1_b89e);           /* call 0x1008b228 */
            ii(0x100a_6ac6, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100a_6ac9, 5); mov(memb[ds, eax + ebp - 0x74], 1);     /* mov byte [eax+ebp-0x74], 0x1 */
            ii(0x100a_6ace, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_6ad1, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x100a_6ad4, 3); lea(eax, memd[ss, ebp - 0x80]);         /* lea eax, [ebp-0x80] */
            ii(0x100a_6ad7, 5); call(0x1007_5e64, -0x3_0c78);           /* call 0x10075e64 */
            ii(0x100a_6adc, 1); push(eax);                              /* push eax */
            ii(0x100a_6add, 3); mov(ecx, memd[ss, ebp - 4]);            /* mov ecx, [ebp-0x4] */
            ii(0x100a_6ae0, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x100a_6ae4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_6ae7, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_6aea, 5); call(0x1008_b228, -0x1_b8c7);           /* call 0x1008b228 */
            ii(0x100a_6aef, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x100a_6af2, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_6af5, 5); call(0x100a_6125, -0x9d5);              /* call 0x100a6125 */
            ii(0x100a_6afa, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100a_6afd, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x100a_6b01, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_6b04, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_6b07, 5); call(0x1008_b228, -0x1_b8e4);           /* call 0x1008b228 */
            ii(0x100a_6b0c, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x100a_6b0f, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_6b14, 5); call(0x100a_4a73, -0x20a6);             /* call 0x100a4a73 */
        l_0x100a_6b19:
            ii(0x100a_6b19, 5); jmp(0x100a_69bf, -0x15f); goto l_0x100a_69bf; /* jmp 0x100a69bf */
        l_0x100a_6b1e:
            ii(0x100a_6b1e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_6b21, 4); mov(memb[ds, eax + 0x1b], 0);           /* mov byte [eax+0x1b], 0x0 */
        l_0x100a_6b25:
            ii(0x100a_6b25, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_6b28, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_6b2b, 5); call(Definitions.my_2_get_count, -0x1_b7c8); /* call 0x1008b368 */
            ii(0x100a_6b30, 1); cwde();                                 /* cwde */
            ii(0x100a_6b31, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_6b33, 2); if(jnz(0x100a_6b86, 0x51)) goto l_0x100a_6b86; /* jnz 0x100a6b86 */
            ii(0x100a_6b35, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_6b37, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_6b3a, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100a_6b3d, 5); call(0x1013_ad71, 0x9_422f);            /* call 0x1013ad71 */
            ii(0x100a_6b42, 2); test(al, al);                           /* test al, al */
            ii(0x100a_6b44, 2); if(jz(0x100a_6b6c, 0x26)) goto l_0x100a_6b6c; /* jz 0x100a6b6c */
            ii(0x100a_6b46, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_6b49, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100a_6b4c, 5); call(0x1008_af28, -0x1_bc29);           /* call 0x1008af28 */
            ii(0x100a_6b51, 6); mov(memd[ss, ebp - 0x84], eax);         /* mov [ebp-0x84], eax */
            ii(0x100a_6b57, 6); mov(eax, memd[ss, ebp - 0x84]);         /* mov eax, [ebp-0x84] */
            ii(0x100a_6b5d, 3); mov(ebx, memd[ds, eax + 2]);            /* mov ebx, [eax+0x2] */
            ii(0x100a_6b60, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_6b63, 6); mov(eax, memd[ss, ebp - 0x84]);         /* mov eax, [ebp-0x84] */
            ii(0x100a_6b69, 3); call_abs(memd[ds, ebx + 0x38]);         /* call dword [ebx+0x38] */
        l_0x100a_6b6c:
            ii(0x100a_6b6c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_6b6e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_6b71, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100a_6b74, 5); call(0x1008_afe4, -0x1_bb95);           /* call 0x1008afe4 */
            ii(0x100a_6b79, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_6b7c, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_6b81, 5); call(0x100a_5e27, -0xd5f);              /* call 0x100a5e27 */
        l_0x100a_6b86:
            ii(0x100a_6b86, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_6b88, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_6b89, 1); pop(edi);                               /* pop edi */
            ii(0x100a_6b8a, 1); pop(esi);                               /* pop esi */
            ii(0x100a_6b8b, 1); pop(edx);                               /* pop edx */
            ii(0x100a_6b8c, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_6b8d, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_6b8e, 1); ret();                                  /* ret */
        }
    }
}
