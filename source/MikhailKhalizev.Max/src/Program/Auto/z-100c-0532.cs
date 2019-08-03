using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3cb92a6c-790a-4d4b-bfa6-867646156253")]
        public void Method_100c_0532()
        {
            ii(0x100c_0532, 5); pushd(0x44);                            /* push 0x44 */
            ii(0x100c_0537, 5); calld(Definitions.sys_check_available_stack_size, 0xa5816); /* call 0x10165d52 */
            ii(0x100c_053c, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_053d, 1); pushd(esi);                             /* push esi */
            ii(0x100c_053e, 1); pushd(edi);                             /* push edi */
            ii(0x100c_053f, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_0540, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_0542, 6); sub(esp, 0x30);                         /* sub esp, 0x30 */
            ii(0x100c_0548, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_054b, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100c_054e, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x100c_0551, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_0554, 5); calld(0x1007_623c, -0x4a31d);           /* call 0x1007623c */
            ii(0x100c_0559, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100c_055c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_055f, 4); mov(ax, memw_a32[ds, eax + 0x12]);      /* mov ax, [eax+0x12] */
            ii(0x100c_0563, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100c_0566, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_0569, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x100c_056c, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100c_056e, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100c_0571, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_0574, 5); calld(0x1007_6074, -0x4a505);           /* call 0x10076074 */
            ii(0x100c_0579, 2); test(al, al);                           /* test al, al */
            ii(0x100c_057b, 2); if(jnzd(0x100c_0592, 0x15)) goto l_0x100c_0592; /* jnz 0x100c0592 */
            ii(0x100c_057d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_0580, 3); mov(edx, memd_a32[ds, eax + 0x15]);     /* mov edx, [eax+0x15] */
            ii(0x100c_0583, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_0586, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100c_058a, 5); calld(Definitions.my_min, -0x36e0b);    /* call 0x10089784 */
            ii(0x100c_058f, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
        l_0x100c_0592:
            ii(0x100c_0592, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100c_0595, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_0598, 5); calld(0x1007_0d01, -0x4f89c);           /* call 0x10070d01 */
            ii(0x100c_059d, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100c_05a0, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100c_05a7, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100c_05ab, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x100c_05af, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100c_05b2, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x100c_05b4, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_05b7, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100c_05ba, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_05bd, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100c_05c0, 6); mov(al, memb_a32[ds, eax + 0x101c_81d4]); /* mov al, [eax+0x101c81d4] */
            ii(0x100c_05c6, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100c_05c8, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100c_05cb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_05ce, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x100c_05d1, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_05d4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_05d7, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x100c_05da, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_05dd, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100c_05e0, 5); calld(0x1007_6aac, -0x49b39);           /* call 0x10076aac */
            ii(0x100c_05e5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_05e7, 5); mov(eax, 0x101c_34d8);                  /* mov eax, 0x101c34d8 */
            ii(0x100c_05ec, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x100c_05ee, 5); calld(0x100c_90d6, 0x8ae3);             /* call 0x100c90d6 */
            ii(0x100c_05f3, 1); cwde();                                 /* cwde */
            ii(0x100c_05f4, 2); cmp(eax, esi);                          /* cmp eax, esi */
            ii(0x100c_05f6, 2); if(jled(0x100c_0604, 0xc)) goto l_0x100c_0604; /* jle 0x100c0604 */
            ii(0x100c_05f8, 7); mov(memd_a32[ss, ebp - 0x24], 0);       /* mov dword [ebp-0x24], 0x0 */
            ii(0x100c_05ff, 5); jmpd(0x100c_0776, 0x172); goto l_0x100c_0776; /* jmp 0x100c0776 */
        l_0x100c_0604:
            ii(0x100c_0604, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_0607, 4); cmp(memb_a32[ds, eax + 0x16], 0);       /* cmp byte [eax+0x16], 0x0 */
            ii(0x100c_060b, 2); if(jzd(0x100c_061c, 0xf)) goto l_0x100c_061c; /* jz 0x100c061c */
            ii(0x100c_060d, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x100c_0612, 5); calld(0x1007_5fdc, -0x4a63b);           /* call 0x10075fdc */
            ii(0x100c_0617, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100c_061a, 2); if(jged(0x100c_061e, 0x2)) goto l_0x100c_061e; /* jge 0x100c061e */
        l_0x100c_061c:
            ii(0x100c_061c, 2); jmpd(0x100c_0681, 0x63); goto l_0x100c_0681; /* jmp 0x100c0681 */
        l_0x100c_061e:
            ii(0x100c_061e, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_0621, 3); mov(dl, memb_a32[ds, edx + 0x4e]);      /* mov dl, [edx+0x4e] */
            ii(0x100c_0624, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x100c_062a, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100c_062c, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100c_062f, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100c_0631, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100c_0633, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x100c_0637, 3); lea(ebx, edx + eax);                    /* lea ebx, [edx+eax] */
            ii(0x100c_063a, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_063d, 3); mov(dl, memb_a32[ds, edx + 0x4e]);      /* mov dl, [edx+0x4e] */
            ii(0x100c_0640, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x100c_0646, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100c_0648, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100c_064b, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100c_064d, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100c_064f, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x100c_0653, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_0655, 3); imul(eax, ebx);                         /* imul eax, ebx */
            ii(0x100c_0658, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x100c_065c, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_065e, 2); if(jgd(0x100c_066b, 0xb)) goto l_0x100c_066b; /* jg 0x100c066b */
            ii(0x100c_0660, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_0662, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_0665, 3); mov(al, memb_a32[ds, edx + 0x50]);      /* mov al, [edx+0x50] */
            ii(0x100c_0668, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
        l_0x100c_066b:
            ii(0x100c_066b, 4); cmp(memb_a32[ss, ebp - 0x4], 0x1);      /* cmp byte [ebp-0x4], 0x1 */
            ii(0x100c_066f, 2); if(jled(0x100c_067c, 0xb)) goto l_0x100c_067c; /* jle 0x100c067c */
            ii(0x100c_0671, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_0674, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x100c_0677, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100c_0679, 3); add(memd_a32[ss, ebp - 0x14], eax);     /* add [ebp-0x14], eax */
        l_0x100c_067c:
            ii(0x100c_067c, 5); jmpd(0x100c_0710, 0x8f); goto l_0x100c_0710; /* jmp 0x100c0710 */
        l_0x100c_0681:
            ii(0x100c_0681, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_0684, 4); mov(ax, memw_a32[ds, eax + 0x14]);      /* mov ax, [eax+0x14] */
            ii(0x100c_0688, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100c_068b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_068e, 4); mov(ax, memw_a32[ds, eax + 0x10]);      /* mov ax, [eax+0x10] */
            ii(0x100c_0692, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x100c_0695, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_0697, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_069a, 3); mov(al, memb_a32[ds, edx + 0x50]);      /* mov al, [edx+0x50] */
            ii(0x100c_069d, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100c_06a0, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x100c_06a4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_06a6, 2); if(jled(0x100c_06ff, 0x57)) goto l_0x100c_06ff; /* jle 0x100c06ff */
        l_0x100c_06a8:
            ii(0x100c_06a8, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x100c_06ac, 4); movsx(edx, memw_a32[ss, ebp - 0x2c]);   /* movsx edx, word [ebp-0x2c] */
            ii(0x100c_06b0, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100c_06b3, 4); movsx(ebx, memw_a32[ss, ebp - 0x28]);   /* movsx ebx, word [ebp-0x28] */
            ii(0x100c_06b7, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100c_06b9, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100c_06bc, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100c_06be, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_06c1, 3); mov(dl, memb_a32[ds, edx + 0x4e]);      /* mov dl, [edx+0x4e] */
            ii(0x100c_06c4, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x100c_06ca, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100c_06cc, 3); mov(memd_a32[ss, ebp - 0x30], edx);     /* mov [ebp-0x30], edx */
            ii(0x100c_06cf, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x100c_06d3, 4); movsx(eax, memw_a32[ss, ebp - 0x30]);   /* movsx eax, word [ebp-0x30] */
            ii(0x100c_06d7, 3); lea(ebx, edx + eax);                    /* lea ebx, [edx+eax] */
            ii(0x100c_06da, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x100c_06de, 4); movsx(eax, memw_a32[ss, ebp - 0x30]);   /* movsx eax, word [ebp-0x30] */
            ii(0x100c_06e2, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_06e4, 3); imul(eax, ebx);                         /* imul eax, ebx */
            ii(0x100c_06e7, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x100c_06eb, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_06ed, 2); if(jled(0x100c_06fb, 0xc)) goto l_0x100c_06fb; /* jle 0x100c06fb */
            ii(0x100c_06ef, 4); add(memd_a32[ss, ebp - 0x1c], -0x1 /* 0xff */); /* add dword [ebp-0x1c], 0xffffffff */
            ii(0x100c_06f3, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x100c_06f7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_06f9, 2); if(jgd(0x100c_06fd, 0x2)) goto l_0x100c_06fd; /* jg 0x100c06fd */
        l_0x100c_06fb:
            ii(0x100c_06fb, 2); jmpd(0x100c_06ff, 0x2); goto l_0x100c_06ff; /* jmp 0x100c06ff */
        l_0x100c_06fd:
            ii(0x100c_06fd, 2); jmpd(0x100c_06a8, -0x57); goto l_0x100c_06a8; /* jmp 0x100c06a8 */
        l_0x100c_06ff:
            ii(0x100c_06ff, 4); cmp(memb_a32[ss, ebp - 0x4], 0x1);      /* cmp byte [ebp-0x4], 0x1 */
            ii(0x100c_0703, 2); if(jled(0x100c_0710, 0xb)) goto l_0x100c_0710; /* jle 0x100c0710 */
            ii(0x100c_0705, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_0708, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x100c_070b, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100c_070d, 3); add(memd_a32[ss, ebp - 0x14], eax);     /* add [ebp-0x14], eax */
        l_0x100c_0710:
            ii(0x100c_0710, 4); cmp(memb_a32[ss, ebp - 0x4], 0x1);      /* cmp byte [ebp-0x4], 0x1 */
            ii(0x100c_0714, 2); if(jled(0x100c_0729, 0x13)) goto l_0x100c_0729; /* jle 0x100c0729 */
            ii(0x100c_0716, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x100c_071a, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100c_071e, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100c_0721, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x100c_0725, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_0727, 2); if(jled(0x100c_072b, 0x2)) goto l_0x100c_072b; /* jle 0x100c072b */
        l_0x100c_0729:
            ii(0x100c_0729, 2); jmpd(0x100c_074f, 0x24); goto l_0x100c_074f; /* jmp 0x100c074f */
        l_0x100c_072b:
            ii(0x100c_072b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_072e, 3); mov(al, memb_a32[ds, eax + 0x54]);      /* mov al, [eax+0x54] */
            ii(0x100c_0731, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_0736, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x100c_073a, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100c_073c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_073e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_0741, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x100c_0744, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_0747, 5); calld(Definitions.my_min, -0x36fc8);    /* call 0x10089784 */
            ii(0x100c_074c, 3); add(memd_a32[ss, ebp - 0x1c], eax);     /* add [ebp-0x1c], eax */
        l_0x100c_074f:
            ii(0x100c_074f, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x100c_0753, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_0755, 2); if(jled(0x100c_076f, 0x18)) goto l_0x100c_076f; /* jle 0x100c076f */
            ii(0x100c_0757, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_0759, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100c_075c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_075f, 5); calld(0x1015_d211, 0x9caad);            /* call 0x1015d211 */
            ii(0x100c_0764, 3); mov(edx, memd_a32[ss, ebp - 0x1c]);     /* mov edx, [ebp-0x1c] */
            ii(0x100c_0767, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100c_076a, 3); mov(memd_a32[ss, ebp - 0x24], edx);     /* mov [ebp-0x24], edx */
            ii(0x100c_076d, 2); jmpd(0x100c_0776, 0x7); goto l_0x100c_0776; /* jmp 0x100c0776 */
        l_0x100c_076f:
            ii(0x100c_076f, 7); mov(memd_a32[ss, ebp - 0x24], 0);       /* mov dword [ebp-0x24], 0x0 */
        l_0x100c_0776:
            ii(0x100c_0776, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100c_0779, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_077b, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_077c, 1); popd(edi);                              /* pop edi */
            ii(0x100c_077d, 1); popd(esi);                              /* pop esi */
            ii(0x100c_077e, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_077f, 1); retd(); return;                         /* ret */
        }
    }
}
