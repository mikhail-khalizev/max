using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_61ff-1edabcad")]
        public void Method_1008_61ff()
        {
            ii(0x1008_61ff, 5); push(0x58);                             /* push 0x58 */
            ii(0x1008_6204, 5); call(Definitions.sys_check_available_stack_size, 0xd_fb49); /* call 0x10165d52 */
            ii(0x1008_6209, 1); push(ebx);                              /* push ebx */
            ii(0x1008_620a, 1); push(ecx);                              /* push ecx */
            ii(0x1008_620b, 1); push(edx);                              /* push edx */
            ii(0x1008_620c, 1); push(esi);                              /* push esi */
            ii(0x1008_620d, 1); push(edi);                              /* push edi */
            ii(0x1008_620e, 1); push(ebp);                              /* push ebp */
            ii(0x1008_620f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_6211, 6); sub(esp, 0x3c);                         /* sub esp, 0x3c */
            ii(0x1008_6217, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_621a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_621d, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_6220, 5); call(0x1008_9d08, 0x3ae3);              /* call 0x10089d08 */
            ii(0x1008_6225, 3); lea(ebx, memd[ss, ebp - 0x14]);         /* lea ebx, [ebp-0x14] */
            ii(0x1008_6228, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_622a, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1008_622c, 5); call(0x1008_9be4, 0x39b3);              /* call 0x10089be4 */
            ii(0x1008_6231, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1008_6238, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
            ii(0x1008_623f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_6242, 4); cmp(memb[ds, eax + 0x15], 0x1);         /* cmp byte [eax+0x15], 0x1 */
            ii(0x1008_6246, 2); if(jge(0x1008_624f, 0x7)) goto l_0x1008_624f; /* jge 0x1008624f */
            ii(0x1008_6248, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_624b, 4); mov(memb[ds, eax + 0x15], 0x1);         /* mov byte [eax+0x15], 0x1 */
        l_0x1008_624f:
            ii(0x1008_624f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_6251, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_6254, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_6257, 5); call(0x1013_ad71, 0xb_4b15);            /* call 0x1013ad71 */
            ii(0x1008_625c, 2); test(al, al);                           /* test al, al */
            ii(0x1008_625e, 2); if(jz(0x1008_6274, 0x14)) goto l_0x1008_6274; /* jz 0x10086274 */
            ii(0x1008_6260, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_6263, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_6266, 5); call(0x1008_9d7c, 0x3b11);              /* call 0x10089d7c */
            ii(0x1008_626b, 5); call(0x1008_9f70, 0x3d00);              /* call 0x10089f70 */
            ii(0x1008_6270, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_6272, 2); if(jnz(0x1008_6279, 0x5)) goto l_0x1008_6279; /* jnz 0x10086279 */
        l_0x1008_6274:
            ii(0x1008_6274, 5); jmp(0x1008_6375, 0xfc); goto l_0x1008_6375; /* jmp 0x10086375 */
        l_0x1008_6279:
            ii(0x1008_6279, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_627c, 3); mov(edx, memd[ds, eax + 0x7]);          /* mov edx, [eax+0x7] */
            ii(0x1008_627f, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_6282, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_6285, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_6288, 5); call(0x1008_9d7c, 0x3aef);              /* call 0x10089d7c */
            ii(0x1008_628d, 5); call(0x1008_9f70, 0x3cde);              /* call 0x10089f70 */
            ii(0x1008_6292, 5); call(0x1007_6074, -0x1_0223);           /* call 0x10076074 */
            ii(0x1008_6297, 2); test(al, al);                           /* test al, al */
            ii(0x1008_6299, 2); if(jnz(0x1008_62bd, 0x22)) goto l_0x1008_62bd; /* jnz 0x100862bd */
            ii(0x1008_629b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_629e, 5); call(0x1008_5f4d, -0x356);              /* call 0x10085f4d */
            ii(0x1008_62a3, 2); test(al, al);                           /* test al, al */
            ii(0x1008_62a5, 2); if(jnz(0x1008_62bd, 0x16)) goto l_0x1008_62bd; /* jnz 0x100862bd */
            ii(0x1008_62a7, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_62aa, 4); mov(memb[ds, eax + 0x15], 0x1);         /* mov byte [eax+0x15], 0x1 */
            ii(0x1008_62ae, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_62b0, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1008_62b3, 5); call(0x1008_9044, 0x2d8c);              /* call 0x10089044 */
            ii(0x1008_62b8, 5); jmp(0x1008_6644, 0x387); goto l_0x1008_6644; /* jmp 0x10086644 */
        l_0x1008_62bd:
            ii(0x1008_62bd, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_62c0, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_62c3, 5); call(0x1008_9d7c, 0x3ab4);              /* call 0x10089d7c */
            ii(0x1008_62c8, 5); call(0x1008_9f70, 0x3ca3);              /* call 0x10089f70 */
            ii(0x1008_62cd, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1008_62d0, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1008_62d3, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x1008_62d6, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1008_62d9, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1008_62dc, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x1008_62df, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_62e2, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1008_62e5, 5); call(0x1007_6aac, -0xf83e);             /* call 0x10076aac */
            ii(0x1008_62ea, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_62ed, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_62f0, 5); call(0x1008_9d08, 0x3a13);              /* call 0x10089d08 */
            ii(0x1008_62f5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_62f7, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1008_62fa, 5); call(0x1008_9b68, 0x3869);              /* call 0x10089b68 */
            ii(0x1008_62ff, 2); jmp(0x1008_6309, 0x8); goto l_0x1008_6309; /* jmp 0x10086309 */
        l_0x1008_6301:
            ii(0x1008_6301, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1008_6304, 5); call(0x1007_6bf8, -0xf711);             /* call 0x10076bf8 */
        l_0x1008_6309:
            ii(0x1008_6309, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_630b, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1008_630e, 5); call(0x1013_ad71, 0xb_4a5e);            /* call 0x1013ad71 */
            ii(0x1008_6313, 2); test(al, al);                           /* test al, al */
            ii(0x1008_6315, 2); if(jz(0x1008_6375, 0x5e)) goto l_0x1008_6375; /* jz 0x10086375 */
            ii(0x1008_6317, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1008_631a, 5); call(0x1008_9b34, 0x3815);              /* call 0x10089b34 */
            ii(0x1008_631f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_6321, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_6324, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_6327, 5); call(0x1008_9e08, 0x3adc);              /* call 0x10089e08 */
            ii(0x1008_632c, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1008_632e, 2); if(jz(0x1008_6353, 0x23)) goto l_0x1008_6353; /* jz 0x10086353 */
            ii(0x1008_6330, 3); lea(edx, memd[ss, ebp - 0x1c]);         /* lea edx, [ebp-0x1c] */
            ii(0x1008_6333, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x1008_6336, 5); call(0x1007_5e64, -0x1_04d7);           /* call 0x10075e64 */
            ii(0x1008_633b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_633d, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1008_6340, 5); call(0x1008_9acc, 0x3787);              /* call 0x10089acc */
            ii(0x1008_6345, 5); call(0x1008_9f70, 0x3c26);              /* call 0x10089f70 */
            ii(0x1008_634a, 5); call(0x1008_2d5c, -0x35f3);             /* call 0x10082d5c */
            ii(0x1008_634f, 2); test(al, al);                           /* test al, al */
            ii(0x1008_6351, 2); if(jz(0x1008_6363, 0x10)) goto l_0x1008_6363; /* jz 0x10086363 */
        l_0x1008_6353:
            ii(0x1008_6353, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1008_6356, 5); call(0x1008_9acc, 0x3771);              /* call 0x10089acc */
            ii(0x1008_635b, 5); call(0x1008_9ffc, 0x3c9c);              /* call 0x10089ffc */
            ii(0x1008_6360, 3); add(memd[ss, ebp - 0x10], eax);         /* add [ebp-0x10], eax */
        l_0x1008_6363:
            ii(0x1008_6363, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1008_6366, 5); call(0x1008_9acc, 0x3761);              /* call 0x10089acc */
            ii(0x1008_636b, 5); call(0x1008_a030, 0x3cc0);              /* call 0x1008a030 */
            ii(0x1008_6370, 3); add(memd[ss, ebp - 0xc], eax);          /* add [ebp-0xc], eax */
            ii(0x1008_6373, 2); jmp(0x1008_6301, -0x74); goto l_0x1008_6301; /* jmp 0x10086301 */
        l_0x1008_6375:
            ii(0x1008_6375, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_6378, 4); cmp(ax, memw[ss, ebp - 0x10]);          /* cmp ax, [ebp-0x10] */
            ii(0x1008_637c, 2); if(jl(0x1008_6397, 0x19)) goto l_0x1008_6397; /* jl 0x10086397 */
            ii(0x1008_637e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_6381, 4); cmp(memb[ds, eax + 0x15], 0x1);         /* cmp byte [eax+0x15], 0x1 */
            ii(0x1008_6385, 2); if(jnz(0x1008_6395, 0xe)) goto l_0x1008_6395; /* jnz 0x10086395 */
            ii(0x1008_6387, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_638a, 4); mov(memb[ds, eax + 0x15], 0x2);         /* mov byte [eax+0x15], 0x2 */
            ii(0x1008_638e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_6391, 4); mov(memb[ds, eax + 0x46], 0);           /* mov byte [eax+0x46], 0x0 */
        l_0x1008_6395:
            ii(0x1008_6395, 2); jmp(0x1008_63c0, 0x29); goto l_0x1008_63c0; /* jmp 0x100863c0 */
        l_0x1008_6397:
            ii(0x1008_6397, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_639a, 4); cmp(memb[ds, eax + 0x15], 0x1);         /* cmp byte [eax+0x15], 0x1 */
            ii(0x1008_639e, 2); if(jle(0x1008_63b7, 0x17)) goto l_0x1008_63b7; /* jle 0x100863b7 */
            ii(0x1008_63a0, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_63a3, 4); cmp(memb[ds, eax + 0x15], 0x7);         /* cmp byte [eax+0x15], 0x7 */
            ii(0x1008_63a7, 2); if(jl(0x1008_63b5, 0xc)) goto l_0x1008_63b5; /* jl 0x100863b5 */
            ii(0x1008_63a9, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_63ac, 5); call(0x1008_5dbd, -0x5f4);              /* call 0x10085dbd */
            ii(0x1008_63b1, 2); test(al, al);                           /* test al, al */
            ii(0x1008_63b3, 2); if(jnz(0x1008_63b7, 0x2)) goto l_0x1008_63b7; /* jnz 0x100863b7 */
        l_0x1008_63b5:
            ii(0x1008_63b5, 2); jmp(0x1008_63b9, 0x2); goto l_0x1008_63b9; /* jmp 0x100863b9 */
        l_0x1008_63b7:
            ii(0x1008_63b7, 2); jmp(0x1008_63c0, 0x7); goto l_0x1008_63c0; /* jmp 0x100863c0 */
        l_0x1008_63b9:
            ii(0x1008_63b9, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_63bc, 4); mov(memb[ds, eax + 0x15], 0x1);         /* mov byte [eax+0x15], 0x1 */
        l_0x1008_63c0:
            ii(0x1008_63c0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_63c2, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_63c5, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_63c8, 5); call(0x1013_ad11, 0xb_4944);            /* call 0x1013ad11 */
            ii(0x1008_63cd, 2); test(al, al);                           /* test al, al */
            ii(0x1008_63cf, 2); if(jnz(0x1008_63e5, 0x14)) goto l_0x1008_63e5; /* jnz 0x100863e5 */
            ii(0x1008_63d1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_63d4, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_63d7, 5); call(0x1008_9d7c, 0x39a0);              /* call 0x10089d7c */
            ii(0x1008_63dc, 5); call(0x1008_9f70, 0x3b8f);              /* call 0x10089f70 */
            ii(0x1008_63e1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_63e3, 2); if(jnz(0x1008_6404, 0x1f)) goto l_0x1008_6404; /* jnz 0x10086404 */
        l_0x1008_63e5:
            ii(0x1008_63e5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_63e8, 4); cmp(memb[ds, eax + 0x15], 0x1);         /* cmp byte [eax+0x15], 0x1 */
            ii(0x1008_63ec, 2); if(jle(0x1008_63f5, 0x7)) goto l_0x1008_63f5; /* jle 0x100863f5 */
            ii(0x1008_63ee, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_63f1, 4); mov(memb[ds, eax + 0x15], 0x1);         /* mov byte [eax+0x15], 0x1 */
        l_0x1008_63f5:
            ii(0x1008_63f5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_63f7, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1008_63fa, 5); call(0x1008_9044, 0x2c45);              /* call 0x10089044 */
            ii(0x1008_63ff, 5); jmp(0x1008_6644, 0x240); goto l_0x1008_6644; /* jmp 0x10086644 */
        l_0x1008_6404:
            ii(0x1008_6404, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_6407, 4); cmp(memb[ds, eax + 0x15], 0x5);         /* cmp byte [eax+0x15], 0x5 */
            ii(0x1008_640b, 2); if(jnz(0x1008_6419, 0xc)) goto l_0x1008_6419; /* jnz 0x10086419 */
            ii(0x1008_640d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_6410, 5); call(0x1008_3558, -0x2ebd);             /* call 0x10083558 */
            ii(0x1008_6415, 2); test(al, al);                           /* test al, al */
            ii(0x1008_6417, 2); if(jz(0x1008_641b, 0x2)) goto l_0x1008_641b; /* jz 0x1008641b */
        l_0x1008_6419:
            ii(0x1008_6419, 2); jmp(0x1008_6422, 0x7); goto l_0x1008_6422; /* jmp 0x10086422 */
        l_0x1008_641b:
            ii(0x1008_641b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_641e, 4); mov(memb[ds, eax + 0x15], 0x3);         /* mov byte [eax+0x15], 0x3 */
        l_0x1008_6422:
            ii(0x1008_6422, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_6425, 4); cmp(memb[ds, eax + 0x15], 0x2);         /* cmp byte [eax+0x15], 0x2 */
            ii(0x1008_6429, 2); if(jl(0x1008_6434, 0x9)) goto l_0x1008_6434; /* jl 0x10086434 */
            ii(0x1008_642b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_642e, 4); cmp(memb[ds, eax + 0x15], 0x5);         /* cmp byte [eax+0x15], 0x5 */
            ii(0x1008_6432, 2); if(jl(0x1008_6439, 0x5)) goto l_0x1008_6439; /* jl 0x10086439 */
        l_0x1008_6434:
            ii(0x1008_6434, 5); jmp(0x1008_65ab, 0x172); goto l_0x1008_65ab; /* jmp 0x100865ab */
        l_0x1008_6439:
            ii(0x1008_6439, 4); or(memb[ss, ebp - 0x8], 0x1);           /* or byte [ebp-0x8], 0x1 */
            ii(0x1008_643d, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1008_6440, 5); call(0x1008_9c28, 0x37e3);              /* call 0x10089c28 */
            ii(0x1008_6445, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x1008_6448, 4); and(memb[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1008_644c, 4); or(memb[ss, ebp - 0x8], 0x1);           /* or byte [ebp-0x8], 0x1 */
            ii(0x1008_6450, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x1008_6453, 5); call(0x1007_64fc, -0xff5c);             /* call 0x100764fc */
            ii(0x1008_6458, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x1008_645b, 4); and(memb[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1008_645f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_6462, 5); call(0x1008_4dd5, -0x1692);             /* call 0x10084dd5 */
            ii(0x1008_6467, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_6469, 2); if(jz(0x1008_6474, 0x9)) goto l_0x1008_6474; /* jz 0x10086474 */
            ii(0x1008_646b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_646e, 4); cmp(memb[ds, eax + 0x46], 0);           /* cmp byte [eax+0x46], 0x0 */
            ii(0x1008_6472, 2); if(jnz(0x1008_6476, 0x2)) goto l_0x1008_6476; /* jnz 0x10086476 */
        l_0x1008_6474:
            ii(0x1008_6474, 2); jmp(0x1008_648a, 0x14); goto l_0x1008_648a; /* jmp 0x1008648a */
        l_0x1008_6476:
            ii(0x1008_6476, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_6479, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_647c, 5); call(0x1007_65d0, -0xfeb1);             /* call 0x100765d0 */
            ii(0x1008_6481, 5); call(0x100a_2edb, 0x1_ca55);            /* call 0x100a2edb */
            ii(0x1008_6486, 2); test(al, al);                           /* test al, al */
            ii(0x1008_6488, 2); if(jnz(0x1008_648c, 0x2)) goto l_0x1008_648c; /* jnz 0x1008648c */
        l_0x1008_648a:
            ii(0x1008_648a, 2); jmp(0x1008_64a3, 0x17); goto l_0x1008_64a3; /* jmp 0x100864a3 */
        l_0x1008_648c:
            ii(0x1008_648c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_648f, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_6492, 5); call(0x1007_6574, -0xff23);             /* call 0x10076574 */
            ii(0x1008_6497, 3); mov(al, memb[ds, eax + 0x4e]);          /* mov al, [eax+0x4e] */
            ii(0x1008_649a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_649f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_64a1, 2); if(jg(0x1008_64a5, 0x2)) goto l_0x1008_64a5; /* jg 0x100864a5 */
        l_0x1008_64a3:
            ii(0x1008_64a3, 2); jmp(0x1008_64c6, 0x21); goto l_0x1008_64c6; /* jmp 0x100864c6 */
        l_0x1008_64a5:
            ii(0x1008_64a5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_64a8, 5); call(0x1008_46e6, -0x1dc7);             /* call 0x100846e6 */
            ii(0x1008_64ad, 2); test(al, al);                           /* test al, al */
            ii(0x1008_64af, 2); if(jz(0x1008_64c6, 0x15)) goto l_0x1008_64c6; /* jz 0x100864c6 */
            ii(0x1008_64b1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_64b4, 3); inc(memb[ds, eax + 0x15]);              /* inc byte [eax+0x15] */
            ii(0x1008_64b7, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_64ba, 4); mov(memb[ds, eax + 0x46], 0);           /* mov byte [eax+0x46], 0x0 */
            ii(0x1008_64be, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_64c1, 5); call(0x1008_5cdb, -0x7eb);              /* call 0x10085cdb */
        l_0x1008_64c6:
            ii(0x1008_64c6, 3); lea(edx, memd[ss, ebp - 0x34]);         /* lea edx, [ebp-0x34] */
            ii(0x1008_64c9, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_64cc, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_64cf, 5); call(0x1008_9d7c, 0x38a8);              /* call 0x10089d7c */
            ii(0x1008_64d4, 5); call(0x1008_9f38, 0x3a5f);              /* call 0x10089f38 */
            ii(0x1008_64d9, 5); call(0x100b_8e63, 0x3_2985);            /* call 0x100b8e63 */
            ii(0x1008_64de, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_64e1, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_64e4, 5); call(0x1008_9d08, 0x381f);              /* call 0x10089d08 */
            ii(0x1008_64e9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_64eb, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1008_64ee, 5); call(0x1008_9b68, 0x3675);              /* call 0x10089b68 */
            ii(0x1008_64f3, 2); jmp(0x1008_64fd, 0x8); goto l_0x1008_64fd; /* jmp 0x100864fd */
        l_0x1008_64f5:
            ii(0x1008_64f5, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1008_64f8, 5); call(0x1007_6bf8, -0xf905);             /* call 0x10076bf8 */
        l_0x1008_64fd:
            ii(0x1008_64fd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_64ff, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1008_6502, 5); call(0x1013_ad71, 0xb_486a);            /* call 0x1013ad71 */
            ii(0x1008_6507, 2); test(al, al);                           /* test al, al */
            ii(0x1008_6509, 6); if(jz(0x1008_6597, 0x88)) goto l_0x1008_6597; /* jz 0x10086597 */
            ii(0x1008_650f, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1008_6512, 5); call(0x1008_9acc, 0x35b5);              /* call 0x10089acc */
            ii(0x1008_6517, 5); call(0x1008_9fc4, 0x3aa8);              /* call 0x10089fc4 */
            ii(0x1008_651c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_651e, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x1008_6521, 5); call(0x1007_643c, -0x1_00ea);           /* call 0x1007643c */
            ii(0x1008_6526, 2); jmp(0x1008_6530, 0x8); goto l_0x1008_6530; /* jmp 0x10086530 */
        l_0x1008_6528:
            ii(0x1008_6528, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x1008_652b, 5); call(0x1007_6bf8, -0xf938);             /* call 0x10076bf8 */
        l_0x1008_6530:
            ii(0x1008_6530, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_6532, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x1008_6535, 5); call(0x1013_ad71, 0xb_4837);            /* call 0x1013ad71 */
            ii(0x1008_653a, 2); test(al, al);                           /* test al, al */
            ii(0x1008_653c, 2); if(jz(0x1008_6592, 0x54)) goto l_0x1008_6592; /* jz 0x10086592 */
            ii(0x1008_653e, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x1008_6541, 5); call(0x1007_63a0, -0x1_01a6);           /* call 0x100763a0 */
            ii(0x1008_6546, 5); call(0x1015_2aa9, 0xc_c55e);            /* call 0x10152aa9 */
            ii(0x1008_654b, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x1008_654e, 4); movsx(edx, memw[ss, ebp - 0x38]);       /* movsx edx, word [ebp-0x38] */
            ii(0x1008_6552, 4); movsx(eax, memw[ss, ebp - 0x38]);       /* movsx eax, word [ebp-0x38] */
            ii(0x1008_6556, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1008_6559, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1008_655b, 3); lea(edx, memd[ss, ebp - 0x34]);         /* lea edx, [ebp-0x34] */
            ii(0x1008_655e, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1008_6561, 5); call(0x1007_5e64, -0x1_0702);           /* call 0x10075e64 */
            ii(0x1008_6566, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_6568, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x1008_656b, 5); call(0x1007_63d4, -0x1_019c);           /* call 0x100763d4 */
            ii(0x1008_6570, 5); call(0x1007_0ca1, -0x1_58d4);           /* call 0x10070ca1 */
            ii(0x1008_6575, 1); cwde();                                 /* cwde */
            ii(0x1008_6576, 2); cmp(eax, ebx);                          /* cmp eax, ebx */
            ii(0x1008_6578, 2); if(jg(0x1008_6590, 0x16)) goto l_0x1008_6590; /* jg 0x10086590 */
            ii(0x1008_657a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_657d, 4); mov(memb[ds, eax + 0x15], 0x5);         /* mov byte [eax+0x15], 0x5 */
            ii(0x1008_6581, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_6584, 4); mov(memb[ds, eax + 0x46], 0);           /* mov byte [eax+0x46], 0x0 */
            ii(0x1008_6588, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_658b, 5); call(0x1008_5cdb, -0x8b5);              /* call 0x10085cdb */
        l_0x1008_6590:
            ii(0x1008_6590, 2); jmp(0x1008_6528, -0x6a); goto l_0x1008_6528; /* jmp 0x10086528 */
        l_0x1008_6592:
            ii(0x1008_6592, 5); jmp(0x1008_64f5, -0xa2); goto l_0x1008_64f5; /* jmp 0x100864f5 */
        l_0x1008_6597:
            ii(0x1008_6597, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_6599, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x1008_659c, 5); call(0x1007_5f6c, -0x1_0635);           /* call 0x10075f6c */
            ii(0x1008_65a1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_65a3, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1008_65a6, 5); call(0x1008_9044, 0x2a99);              /* call 0x10089044 */
        l_0x1008_65ab:
            ii(0x1008_65ab, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_65ae, 4); cmp(memb[ds, eax + 0x15], 0x5);         /* cmp byte [eax+0x15], 0x5 */
            ii(0x1008_65b2, 2); if(jz(0x1008_65bd, 0x9)) goto l_0x1008_65bd; /* jz 0x100865bd */
            ii(0x1008_65b4, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_65b7, 4); cmp(memb[ds, eax + 0x15], 0x6);         /* cmp byte [eax+0x15], 0x6 */
            ii(0x1008_65bb, 2); if(jnz(0x1008_65df, 0x22)) goto l_0x1008_65df; /* jnz 0x100865df */
        l_0x1008_65bd:
            ii(0x1008_65bd, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_65c0, 3); mov(edx, memd[ds, eax + 0x7]);          /* mov edx, [eax+0x7] */
            ii(0x1008_65c3, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_65c6, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_65c9, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_65cc, 5); call(0x1008_9d7c, 0x37ab);              /* call 0x10089d7c */
            ii(0x1008_65d1, 5); call(0x1008_9f70, 0x399a);              /* call 0x10089f70 */
            ii(0x1008_65d6, 5); call(0x1007_6074, -0x1_0567);           /* call 0x10076074 */
            ii(0x1008_65db, 2); test(al, al);                           /* test al, al */
            ii(0x1008_65dd, 2); if(jnz(0x1008_65e1, 0x2)) goto l_0x1008_65e1; /* jnz 0x100865e1 */
        l_0x1008_65df:
            ii(0x1008_65df, 2); jmp(0x1008_65f7, 0x16); goto l_0x1008_65f7; /* jmp 0x100865f7 */
        l_0x1008_65e1:
            ii(0x1008_65e1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_65e4, 4); mov(memb[ds, eax + 0x15], 0x7);         /* mov byte [eax+0x15], 0x7 */
            ii(0x1008_65e8, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_65eb, 4); mov(memb[ds, eax + 0x46], 0);           /* mov byte [eax+0x46], 0x0 */
            ii(0x1008_65ef, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_65f2, 5); call(0x1008_5cdb, -0x91c);              /* call 0x10085cdb */
        l_0x1008_65f7:
            ii(0x1008_65f7, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_65fa, 4); cmp(memb[ds, eax + 0x15], 0x7);         /* cmp byte [eax+0x15], 0x7 */
            ii(0x1008_65fe, 2); if(jnz(0x1008_6622, 0x22)) goto l_0x1008_6622; /* jnz 0x10086622 */
            ii(0x1008_6600, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_6603, 3); mov(edx, memd[ds, eax + 0x7]);          /* mov edx, [eax+0x7] */
            ii(0x1008_6606, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_6609, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_660c, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_660f, 5); call(0x1008_9d7c, 0x3768);              /* call 0x10089d7c */
            ii(0x1008_6614, 5); call(0x1008_9f70, 0x3957);              /* call 0x10089f70 */
            ii(0x1008_6619, 5); call(0x1007_6074, -0x1_05aa);           /* call 0x10076074 */
            ii(0x1008_661e, 2); test(al, al);                           /* test al, al */
            ii(0x1008_6620, 2); if(jz(0x1008_6624, 0x2)) goto l_0x1008_6624; /* jz 0x10086624 */
        l_0x1008_6622:
            ii(0x1008_6622, 2); jmp(0x1008_663a, 0x16); goto l_0x1008_663a; /* jmp 0x1008663a */
        l_0x1008_6624:
            ii(0x1008_6624, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_6627, 4); mov(memb[ds, eax + 0x15], 0x5);         /* mov byte [eax+0x15], 0x5 */
            ii(0x1008_662b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_662e, 4); mov(memb[ds, eax + 0x46], 0);           /* mov byte [eax+0x46], 0x0 */
            ii(0x1008_6632, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_6635, 5); call(0x1008_5cdb, -0x95f);              /* call 0x10085cdb */
        l_0x1008_663a:
            ii(0x1008_663a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_663c, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1008_663f, 5); call(0x1008_9044, 0x2a00);              /* call 0x10089044 */
        l_0x1008_6644:
            ii(0x1008_6644, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_6646, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_6647, 1); pop(edi);                               /* pop edi */
            ii(0x1008_6648, 1); pop(esi);                               /* pop esi */
            ii(0x1008_6649, 1); pop(edx);                               /* pop edx */
            ii(0x1008_664a, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_664b, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_664c, 1); ret();                                  /* ret */
        }
    }
}
