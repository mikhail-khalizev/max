using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_60d2-3c5082ca")]
        public void Method_100c_60d2()
        {
            ii(0x100c_60d2, 5); push(0x44);                             /* push 0x44 */
            ii(0x100c_60d7, 5); call(Definitions.sys_check_available_stack_size, 0x9_fc76); /* call 0x10165d52 */
            ii(0x100c_60dc, 1); push(ebx);                              /* push ebx */
            ii(0x100c_60dd, 1); push(ecx);                              /* push ecx */
            ii(0x100c_60de, 1); push(esi);                              /* push esi */
            ii(0x100c_60df, 1); push(edi);                              /* push edi */
            ii(0x100c_60e0, 1); push(ebp);                              /* push ebp */
            ii(0x100c_60e1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_60e3, 6); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x100c_60e9, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_60ec, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100c_60ef, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_60f2, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_60f5, 5); call(0x1013_bb7b, 0x7_5a81);            /* call 0x1013bb7b */
            ii(0x100c_60fa, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100c_60ff, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_6102, 3); add(edx, 0x2);                          /* add edx, 0x2 */
            ii(0x100c_6105, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_6108, 5); call(0x1013_ba86, 0x7_5979);            /* call 0x1013ba86 */
            ii(0x100c_610d, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_6110, 3); add(edx, 0x3);                          /* add edx, 0x3 */
            ii(0x100c_6113, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_6116, 5); call(0x1013_bb7b, 0x7_5a60);            /* call 0x1013bb7b */
            ii(0x100c_611b, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_611e, 3); add(edx, 0x5);                          /* add edx, 0x5 */
            ii(0x100c_6121, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_6124, 5); call(0x1013_bb7b, 0x7_5a52);            /* call 0x1013bb7b */
            ii(0x100c_6129, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_612c, 3); add(edx, 0x7);                          /* add edx, 0x7 */
            ii(0x100c_612f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_6132, 5); call(0x1013_bb7b, 0x7_5a44);            /* call 0x1013bb7b */
            ii(0x100c_6137, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_613a, 3); add(edx, 0x7b);                         /* add edx, 0x7b */
            ii(0x100c_613d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_6140, 5); call(0x1013_bb7b, 0x7_5a36);            /* call 0x1013bb7b */
            ii(0x100c_6145, 3); lea(edx, memd[ss, ebp - 0x10]);         /* lea edx, [ebp-0x10] */
            ii(0x100c_6148, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_614b, 5); call(0x1013_bb7b, 0x7_5a2b);            /* call 0x1013bb7b */
            ii(0x100c_6150, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_6153, 3); add(eax, 0x43);                         /* add eax, 0x43 */
            ii(0x100c_6156, 5); call(0x1013_a6f4, 0x7_4599);            /* call 0x1013a6f4 */
            ii(0x100c_615b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_615e, 3); add(eax, 0x4d);                         /* add eax, 0x4d */
            ii(0x100c_6161, 5); call(0x1013_a6f4, 0x7_458e);            /* call 0x1013a6f4 */
            ii(0x100c_6166, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_6169, 3); add(eax, 0x57);                         /* add eax, 0x57 */
            ii(0x100c_616c, 5); call(0x1013_a6f4, 0x7_4583);            /* call 0x1013a6f4 */
        l_0x100c_6171:
            ii(0x100c_6171, 3); dec(memd[ss, ebp - 0x10]);              /* dec dword [ebp-0x10] */
            ii(0x100c_6174, 5); cmp(memw[ss, ebp - 0x10], -0x1 /* 0xff */); /* cmp word [ebp-0x10], 0xffff */
            ii(0x100c_6179, 2); if(jz(0x100c_61dc, 0x61)) goto l_0x100c_61dc; /* jz 0x100c61dc */
            ii(0x100c_617b, 5); mov(eax, 0x15);                         /* mov eax, 0x15 */
            ii(0x100c_6180, 5); call(Definitions.sys_new, 0x9_fc7b);    /* call 0x10165e00 */
            ii(0x100c_6185, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100c_6188, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_618b, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100c_618e, 4); cmp(memd[ss, ebp - 0x18], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x100c_6192, 2); if(jz(0x100c_61aa, 0x16)) goto l_0x100c_61aa; /* jz 0x100c61aa */
            ii(0x100c_6194, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100c_6197, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_619a, 5); call(Definitions.my_ctor_c14, -0xd4e0); /* call 0x100b8cbf */
            ii(0x100c_619f, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100c_61a2, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100c_61a5, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x100c_61a8, 2); jmp(0x100c_61b0, 0x6); goto l_0x100c_61b0; /* jmp 0x100c61b0 */
        l_0x100c_61aa:
            ii(0x100c_61aa, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100c_61ad, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
        l_0x100c_61b0:
            ii(0x100c_61b0, 3); mov(edx, memd[ss, ebp - 0x20]);         /* mov edx, [ebp-0x20] */
            ii(0x100c_61b3, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x100c_61b6, 5); call(0x100c_b074, 0x4eb9);              /* call 0x100cb074 */
            ii(0x100c_61bb, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x100c_61be, 5); call(0x1008_a284, -0x3_bf3f);           /* call 0x1008a284 */
            ii(0x100c_61c3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_61c5, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_61c8, 3); add(eax, 0x43);                         /* add eax, 0x43 */
            ii(0x100c_61cb, 5); call(0x100c_afd0, 0x4e00);              /* call 0x100cafd0 */
            ii(0x100c_61d0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_61d2, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x100c_61d5, 5); call(0x1008_8e0c, -0x3_d3ce);           /* call 0x10088e0c */
            ii(0x100c_61da, 2); jmp(0x100c_6171, -0x6b); goto l_0x100c_6171; /* jmp 0x100c6171 */
        l_0x100c_61dc:
            ii(0x100c_61dc, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_61df, 4); cmp(memd[ds, eax + 0x63], 0);           /* cmp dword [eax+0x63], 0x0 */
            ii(0x100c_61e3, 2); if(jnz(0x100c_61ee, 0x9)) goto l_0x100c_61ee; /* jnz 0x100c61ee */
            ii(0x100c_61e5, 7); mov(memd[ss, ebp - 0x28], 0);           /* mov dword [ebp-0x28], 0x0 */
            ii(0x100c_61ec, 2); jmp(0x100c_6207, 0x19); goto l_0x100c_6207; /* jmp 0x100c6207 */
        l_0x100c_61ee:
            ii(0x100c_61ee, 5); mov(ecx, 0x10c4);                       /* mov ecx, 0x10c4 */
            ii(0x100c_61f3, 5); mov(ebx, StringDefinitions.AiPlayrCpp2); /* mov ebx, 0x101a12ec */
            ii(0x100c_61f8, 5); mov(edx, StringDefinitions.InfoMapEqual0); /* mov edx, 0x101a12f9 */
            ii(0x100c_61fd, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_61ff, 5); call(Definitions.sys_assert, 0x9_fb8e); /* call 0x10165d92 */
            ii(0x100c_6204, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
        l_0x100c_6207:
            ii(0x100c_6207, 3); lea(edx, memd[ss, ebp - 0x10]);         /* lea edx, [ebp-0x10] */
            ii(0x100c_620a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_620d, 5); call(0x1013_bb7b, 0x7_5969);            /* call 0x1013bb7b */
            ii(0x100c_6212, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100c_6216, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_6218, 6); if(jz(0x100c_62d7, 0xb9)) goto l_0x100c_62d7; /* jz 0x100c62d7 */
            ii(0x100c_621e, 5); mov(eax, memd[ds, 0x101c_8170]);        /* mov eax, [0x101c8170] */
            ii(0x100c_6223, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_6226, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100c_6229, 5); call(Definitions.sys_new_arr, 0x9_fde2); /* call 0x10166010 */
            ii(0x100c_622e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_6230, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_6233, 3); mov(memd[ds, eax + 0x63], edx);         /* mov [eax+0x63], edx */
            ii(0x100c_6236, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x100c_623d, 2); jmp(0x100c_6245, 0x6); goto l_0x100c_6245; /* jmp 0x100c6245 */
        l_0x100c_623f:
            ii(0x100c_623f, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_6242, 3); inc(memd[ss, ebp - 0x10]);              /* inc dword [ebp-0x10] */
        l_0x100c_6245:
            ii(0x100c_6245, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_6248, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x100c_624f, 6); if(jge(0x100c_62d7, 0x82)) goto l_0x100c_62d7; /* jge 0x100c62d7 */
            ii(0x100c_6255, 5); mov(eax, memd[ds, 0x101c_8172]);        /* mov eax, [0x101c8172] */
            ii(0x100c_625a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_625d, 5); call(Definitions.sys_new_arr, 0x9_fdae); /* call 0x10166010 */
            ii(0x100c_6262, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_6264, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100c_6268, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100c_626b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_626d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_6270, 3); mov(eax, memd[ds, eax + 0x63]);         /* mov eax, [eax+0x63] */
            ii(0x100c_6273, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_6275, 2); mov(memd[ds, eax], ebx);                /* mov [eax], ebx */
            ii(0x100c_6277, 6); mov(ebx, memd[ds, 0x101c_8172]);        /* mov ebx, [0x101c8172] */
            ii(0x100c_627d, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_6280, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100c_6284, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100c_6287, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_6289, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_628c, 3); mov(eax, memd[ds, eax + 0x63]);         /* mov eax, [eax+0x63] */
            ii(0x100c_628f, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_6291, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x100c_6293, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_6296, 5); call(0x1013_ba86, 0x7_57eb);            /* call 0x1013ba86 */
            ii(0x100c_629b, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
            ii(0x100c_62a2, 2); jmp(0x100c_62aa, 0x6); goto l_0x100c_62aa; /* jmp 0x100c62aa */
        l_0x100c_62a4:
            ii(0x100c_62a4, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100c_62a7, 3); inc(memd[ss, ebp - 0xc]);               /* inc dword [ebp-0xc] */
        l_0x100c_62aa:
            ii(0x100c_62aa, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100c_62ad, 7); cmp(ax, memw[ds, 0x101c_8174]);         /* cmp ax, [0x101c8174] */
            ii(0x100c_62b4, 2); if(jge(0x100c_62d2, 0x1c)) goto l_0x100c_62d2; /* jge 0x100c62d2 */
            ii(0x100c_62b6, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100c_62ba, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100c_62bd, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_62c0, 3); mov(eax, memd[ds, eax + 0x63]);         /* mov eax, [eax+0x63] */
            ii(0x100c_62c3, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_62c5, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x100c_62c9, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100c_62cb, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_62cd, 3); and(memb[ds, eax], 0x3);                /* and byte [eax], 0x3 */
            ii(0x100c_62d0, 2); jmp(0x100c_62a4, -0x2e); goto l_0x100c_62a4; /* jmp 0x100c62a4 */
        l_0x100c_62d2:
            ii(0x100c_62d2, 5); jmp(0x100c_623f, -0x98); goto l_0x100c_623f; /* jmp 0x100c623f */
        l_0x100c_62d7:
            ii(0x100c_62d7, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_62da, 4); cmp(memd[ds, eax + 0x67], 0);           /* cmp dword [eax+0x67], 0x0 */
            ii(0x100c_62de, 2); if(jnz(0x100c_62e9, 0x9)) goto l_0x100c_62e9; /* jnz 0x100c62e9 */
            ii(0x100c_62e0, 7); mov(memd[ss, ebp - 0x2c], 0);           /* mov dword [ebp-0x2c], 0x0 */
            ii(0x100c_62e7, 2); jmp(0x100c_6302, 0x19); goto l_0x100c_6302; /* jmp 0x100c6302 */
        l_0x100c_62e9:
            ii(0x100c_62e9, 5); mov(ecx, 0x10d1);                       /* mov ecx, 0x10d1 */
            ii(0x100c_62ee, 5); mov(ebx, StringDefinitions.AiPlayrCpp); /* mov ebx, 0x101a1307 */
            ii(0x100c_62f3, 5); mov(edx, StringDefinitions.MineMapEqual0); /* mov edx, 0x101a1314 */
            ii(0x100c_62f8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_62fa, 5); call(Definitions.sys_assert, 0x9_fa93); /* call 0x10165d92 */
            ii(0x100c_62ff, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
        l_0x100c_6302:
            ii(0x100c_6302, 3); lea(edx, memd[ss, ebp - 0x10]);         /* lea edx, [ebp-0x10] */
            ii(0x100c_6305, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_6308, 5); call(0x1013_bb7b, 0x7_586e);            /* call 0x1013bb7b */
            ii(0x100c_630d, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100c_6311, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_6313, 6); if(jz(0x100c_6394, 0x7b)) goto l_0x100c_6394; /* jz 0x100c6394 */
            ii(0x100c_6319, 5); mov(eax, memd[ds, 0x101c_8170]);        /* mov eax, [0x101c8170] */
            ii(0x100c_631e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_6321, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100c_6324, 5); call(Definitions.sys_new_arr, 0x9_fce7); /* call 0x10166010 */
            ii(0x100c_6329, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_632b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_632e, 3); mov(memd[ds, eax + 0x67], edx);         /* mov [eax+0x67], edx */
            ii(0x100c_6331, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x100c_6338, 2); jmp(0x100c_6340, 0x6); goto l_0x100c_6340; /* jmp 0x100c6340 */
        l_0x100c_633a:
            ii(0x100c_633a, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_633d, 3); inc(memd[ss, ebp - 0x10]);              /* inc dword [ebp-0x10] */
        l_0x100c_6340:
            ii(0x100c_6340, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_6343, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x100c_634a, 2); if(jge(0x100c_6394, 0x48)) goto l_0x100c_6394; /* jge 0x100c6394 */
            ii(0x100c_634c, 5); mov(eax, memd[ds, 0x101c_8172]);        /* mov eax, [0x101c8172] */
            ii(0x100c_6351, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_6354, 5); call(Definitions.sys_new_arr, 0x9_fcb7); /* call 0x10166010 */
            ii(0x100c_6359, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_635b, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100c_635f, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100c_6362, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_6364, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_6367, 3); mov(eax, memd[ds, eax + 0x67]);         /* mov eax, [eax+0x67] */
            ii(0x100c_636a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_636c, 2); mov(memd[ds, eax], ebx);                /* mov [eax], ebx */
            ii(0x100c_636e, 6); mov(ebx, memd[ds, 0x101c_8172]);        /* mov ebx, [0x101c8172] */
            ii(0x100c_6374, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_6377, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100c_637b, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100c_637e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_6380, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_6383, 3); mov(eax, memd[ds, eax + 0x67]);         /* mov eax, [eax+0x67] */
            ii(0x100c_6386, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_6388, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x100c_638a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_638d, 5); call(0x1013_ba86, 0x7_56f4);            /* call 0x1013ba86 */
            ii(0x100c_6392, 2); jmp(0x100c_633a, -0x5a); goto l_0x100c_633a; /* jmp 0x100c633a */
        l_0x100c_6394:
            ii(0x100c_6394, 5); mov(ebx, 0x4);                          /* mov ebx, 0x4 */
            ii(0x100c_6399, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_639c, 3); add(edx, 0x77);                         /* add edx, 0x77 */
            ii(0x100c_639f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_63a2, 5); call(0x1013_ba86, 0x7_56df);            /* call 0x1013ba86 */
            ii(0x100c_63a7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_63a9, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_63aa, 1); pop(edi);                               /* pop edi */
            ii(0x100c_63ab, 1); pop(esi);                               /* pop esi */
            ii(0x100c_63ac, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_63ad, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_63ae, 1); ret();                                  /* ret */
        }
    }
}
