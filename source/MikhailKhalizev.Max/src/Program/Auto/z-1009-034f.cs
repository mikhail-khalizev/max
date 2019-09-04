using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_034f-797ff362")]
        public void Method_1009_034f()
        {
            ii(0x1009_034f, 5);  push(0xa8);                           /* push 0xa8 */
            ii(0x1009_0354, 5);  call(Definitions.sys_check_available_stack_size, 0xd_59f9);/* call 0x10165d52 */
            ii(0x1009_0359, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_035a, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_035b, 1);  push(esi);                            /* push esi */
            ii(0x1009_035c, 1);  push(edi);                            /* push edi */
            ii(0x1009_035d, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_035e, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_0360, 6);  sub(esp, 0x90);                       /* sub esp, 0x90 */
            ii(0x1009_0366, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_0369, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_036c, 4);  or(memb[ss, ebp - 12], 1);            /* or byte [ebp-0xc], 0x1 */
            ii(0x1009_0370, 5);  mov(edx, 0xa);                        /* mov edx, 0xa */
            ii(0x1009_0375, 3);  lea(eax, memd[ss, ebp - 72]);         /* lea eax, [ebp-0x48] */
            ii(0x1009_0378, 5);  call(0x1009_c1fc, 0xbe7f);            /* call 0x1009c1fc */
            ii(0x1009_037d, 3);  mov(memd[ss, ebp - 56], eax);         /* mov [ebp-0x38], eax */
            ii(0x1009_0380, 4);  and(memb[ss, ebp - 12], -2 /* 0xfe */);/* and byte [ebp-0xc], 0xfe */
            ii(0x1009_0384, 7);  mov(memd[ss, ebp - 20], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x1009_038b, 5);  call(0x1014_82f4, 0xb_7f64);          /* call 0x101482f4 */
            ii(0x1009_0390, 3);  mov(memd[ss, ebp - 52], eax);         /* mov [ebp-0x34], eax */
            ii(0x1009_0393, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_0396, 6);  mov(memw[ds, eax + 33], 0);           /* mov word [eax+0x21], 0x0 */
            ii(0x1009_039c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_039f, 3);  movsx(edx, memw[ds, eax]);            /* movsx edx, word [eax] */
            ii(0x1009_03a2, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_03a5, 3);  mov(memd[ds, eax + 1], edx);          /* mov [eax+0x1], edx */
            ii(0x1009_03a8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_03ab, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x1009_03ad, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1009_03b0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_03b3, 3);  mov(memd[ds, eax + 5], edx);          /* mov [eax+0x5], edx */
            ii(0x1009_03b6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_03b9, 3);  movsx(edx, memw[ds, eax]);            /* movsx edx, word [eax] */
            ii(0x1009_03bc, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_03bf, 3);  mov(memd[ds, eax + 9], edx);          /* mov [eax+0x9], edx */
            ii(0x1009_03c2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_03c5, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x1009_03c7, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1009_03ca, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_03cd, 3);  mov(memd[ds, eax + 13], edx);         /* mov [eax+0xd], edx */
            ii(0x1009_03d0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_03d3, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1009_03d6, 3);  mov(esi, memd[ss, ebp - 44]);         /* mov esi, [ebp-0x2c] */
            ii(0x1009_03d9, 3);  mov(esi, memd[ds, esi + 35]);         /* mov esi, [esi+0x23] */
            ii(0x1009_03dc, 3);  mov(ebx, memd[ss, ebp - 8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1009_03df, 3);  mov(ebx, memd[ds, ebx + 19]);         /* mov ebx, [ebx+0x13] */
            ii(0x1009_03e2, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1009_03e5, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_03e8, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1009_03eb, 5);  call(0x1007_5e64, -0x1_a58c);         /* call 0x10075e64 */
            ii(0x1009_03f0, 3);  mov(ecx, memd[ss, ebp - 44]);         /* mov ecx, [ebp-0x2c] */
            ii(0x1009_03f3, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_03f5, 2);  mov(eax, ecx);                        /* mov eax, ecx */
            ii(0x1009_03f7, 2);  call_abs(memd[ds, esi]);              /* call dword [esi] */
            ii(0x1009_03f9, 4);  mov(memw[ss, ebp - 78], ax);          /* mov [ebp-0x4e], ax */
            ii(0x1009_03fd, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_0400, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1009_0403, 3);  mov(esi, memd[ss, ebp - 36]);         /* mov esi, [ebp-0x24] */
            ii(0x1009_0406, 3);  mov(esi, memd[ds, esi + 35]);         /* mov esi, [esi+0x23] */
            ii(0x1009_0409, 3);  mov(ebx, memd[ss, ebp - 8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1009_040c, 3);  mov(ebx, memd[ds, ebx + 27]);         /* mov ebx, [ebx+0x1b] */
            ii(0x1009_040f, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1009_0412, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_0415, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x1009_0418, 5);  call(0x1007_5e64, -0x1_a5b9);         /* call 0x10075e64 */
            ii(0x1009_041d, 3);  mov(ecx, memd[ss, ebp - 36]);         /* mov ecx, [ebp-0x24] */
            ii(0x1009_0420, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_0422, 2);  mov(eax, ecx);                        /* mov eax, ecx */
            ii(0x1009_0424, 3);  call_abs(memd[ds, esi + 4]);          /* call dword [esi+0x4] */
            ii(0x1009_0427, 4);  mov(memw[ss, ebp - 76], ax);          /* mov [ebp-0x4c], ax */
            ii(0x1009_042b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_042e, 3);  mov(ax, memw[ds, eax]);               /* mov ax, [eax] */
            ii(0x1009_0431, 4);  mov(memw[ss, ebp - 80], ax);          /* mov [ebp-0x50], ax */
            ii(0x1009_0435, 3);  mov(eax, memd[ss, ebp - 76]);         /* mov eax, [ebp-0x4c] */
            ii(0x1009_0438, 3);  sub(eax, memd[ss, ebp - 78]);         /* sub eax, [ebp-0x4e] */
            ii(0x1009_043b, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1009_043e, 4);  add(memw[ds, edx + 33], ax);          /* add [edx+0x21], ax */
            ii(0x1009_0442, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_0445, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1009_0448, 3);  mov(esi, memd[ss, ebp - 32]);         /* mov esi, [ebp-0x20] */
            ii(0x1009_044b, 3);  mov(esi, memd[ds, esi + 35]);         /* mov esi, [esi+0x23] */
            ii(0x1009_044e, 4);  movsx(ecx, memw[ss, ebp - 76]);       /* movsx ecx, word [ebp-0x4c] */
            ii(0x1009_0452, 4);  movsx(ebx, memw[ss, ebp - 78]);       /* movsx ebx, word [ebp-0x4e] */
            ii(0x1009_0456, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_0459, 3);  movsx(edx, memw[ds, edx]);            /* movsx edx, word [edx] */
            ii(0x1009_045c, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1009_045f, 3);  call_abs(memd[ds, esi + 12]);         /* call dword [esi+0xc] */
            ii(0x1009_0462, 3);  lea(edx, memd[ss, ebp - 80]);         /* lea edx, [ebp-0x50] */
            ii(0x1009_0465, 3);  lea(eax, memd[ss, ebp - 72]);         /* lea eax, [ebp-0x48] */
            ii(0x1009_0468, 5);  call(0x1009_c18c, 0xbd1f);            /* call 0x1009c18c */
        l_0x1009_046d:
            ii(0x1009_046d, 3);  lea(eax, memd[ss, ebp - 72]);         /* lea eax, [ebp-0x48] */
            ii(0x1009_0470, 5);  call(Definitions.my_3_get_count, -0x4ff5);/* call 0x1008b480 */
            ii(0x1009_0475, 1);  cwde();                               /* cwde */
            ii(0x1009_0476, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1009_0478, 6);  if(jle(0x1009_07ae, 0x330)) goto l_0x1009_07ae;/* jle 0x100907ae */
            ii(0x1009_047e, 3);  lea(eax, memd[ss, ebp - 72]);         /* lea eax, [ebp-0x48] */
            ii(0x1009_0481, 5);  call(Definitions.my_3_get_count, -0x5006);/* call 0x1008b480 */
            ii(0x1009_0486, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_0489, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_048c, 4);  cmp(ax, memw[ss, ebp - 20]);          /* cmp ax, [ebp-0x14] */
            ii(0x1009_0490, 2);  if(jle(0x1009_0498, 6)) goto l_0x1009_0498;/* jle 0x10090498 */
            ii(0x1009_0492, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_0495, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
        l_0x1009_0498:
            ii(0x1009_0498, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_049b, 1);  dec(eax);                             /* dec eax */
            ii(0x1009_049c, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1009_049f, 3);  lea(eax, memd[ss, ebp - 72]);         /* lea eax, [ebp-0x48] */
            ii(0x1009_04a2, 5);  call(0x1009_c150, 0xbca9);            /* call 0x1009c150 */
            ii(0x1009_04a7, 3);  lea(edi, memd[ss, ebp - 80]);         /* lea edi, [ebp-0x50] */
            ii(0x1009_04aa, 2);  mov(esi, eax);                        /* mov esi, eax */
            ii(0x1009_04ac, 1);  movsd();                              /* movsd */
            ii(0x1009_04ad, 2);  movsw();                              /* movsw */
            ii(0x1009_04af, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_04b2, 1);  dec(eax);                             /* dec eax */
            ii(0x1009_04b3, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1009_04b6, 3);  lea(eax, memd[ss, ebp - 72]);         /* lea eax, [ebp-0x48] */
            ii(0x1009_04b9, 5);  call(0x100c_db14, 0x3_d656);          /* call 0x100cdb14 */
            ii(0x1009_04be, 4);  movsx(edx, memw[ss, ebp - 78]);       /* movsx edx, word [ebp-0x4e] */
            ii(0x1009_04c2, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_04c5, 3);  cmp(edx, memd[ds, eax + 5]);          /* cmp edx, [eax+0x5] */
            ii(0x1009_04c8, 2);  if(jge(0x1009_04d4, 0xa)) goto l_0x1009_04d4;/* jge 0x100904d4 */
            ii(0x1009_04ca, 4);  movsx(eax, memw[ss, ebp - 78]);       /* movsx eax, word [ebp-0x4e] */
            ii(0x1009_04ce, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1009_04d1, 3);  mov(memd[ds, edx + 5], eax);          /* mov [edx+0x5], eax */
        l_0x1009_04d4:
            ii(0x1009_04d4, 4);  movsx(edx, memw[ss, ebp - 80]);       /* movsx edx, word [ebp-0x50] */
            ii(0x1009_04d8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_04db, 3);  cmp(edx, memd[ds, eax + 1]);          /* cmp edx, [eax+0x1] */
            ii(0x1009_04de, 2);  if(jge(0x1009_04ea, 0xa)) goto l_0x1009_04ea;/* jge 0x100904ea */
            ii(0x1009_04e0, 4);  movsx(eax, memw[ss, ebp - 80]);       /* movsx eax, word [ebp-0x50] */
            ii(0x1009_04e4, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1009_04e7, 3);  mov(memd[ds, edx + 1], eax);          /* mov [edx+0x1], eax */
        l_0x1009_04ea:
            ii(0x1009_04ea, 4);  movsx(edx, memw[ss, ebp - 80]);       /* movsx edx, word [ebp-0x50] */
            ii(0x1009_04ee, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_04f1, 3);  cmp(edx, memd[ds, eax + 9]);          /* cmp edx, [eax+0x9] */
            ii(0x1009_04f4, 2);  if(jl(0x1009_0500, 0xa)) goto l_0x1009_0500;/* jl 0x10090500 */
            ii(0x1009_04f6, 4);  movsx(eax, memw[ss, ebp - 80]);       /* movsx eax, word [ebp-0x50] */
            ii(0x1009_04fa, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1009_04fd, 3);  mov(memd[ds, edx + 9], eax);          /* mov [edx+0x9], eax */
        l_0x1009_0500:
            ii(0x1009_0500, 4);  movsx(edx, memw[ss, ebp - 76]);       /* movsx edx, word [ebp-0x4c] */
            ii(0x1009_0504, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_0507, 3);  cmp(edx, memd[ds, eax + 13]);         /* cmp edx, [eax+0xd] */
            ii(0x1009_050a, 2);  if(jle(0x1009_0516, 0xa)) goto l_0x1009_0516;/* jle 0x10090516 */
            ii(0x1009_050c, 4);  movsx(eax, memw[ss, ebp - 76]);       /* movsx eax, word [ebp-0x4c] */
            ii(0x1009_0510, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1009_0513, 3);  mov(memd[ds, edx + 13], eax);         /* mov [edx+0xd], eax */
        l_0x1009_0516:
            ii(0x1009_0516, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_0519, 3);  cmp(memb[ds, eax], 0);                /* cmp byte [eax], 0x0 */
            ii(0x1009_051c, 2);  if(jz(0x1009_0534, 0x16)) goto l_0x1009_0534;/* jz 0x10090534 */
            ii(0x1009_051e, 4);  movsx(eax, memw[ss, ebp - 78]);       /* movsx eax, word [ebp-0x4e] */
            ii(0x1009_0522, 3);  lea(edx, memd[ds, eax - 1]);          /* lea edx, [eax-0x1] */
            ii(0x1009_0525, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_0528, 3);  mov(eax, memd[ds, eax + 21]);         /* mov eax, [eax+0x15] */
            ii(0x1009_052b, 5);  call(0x1007_6e7c, -0x1_96b4);         /* call 0x10076e7c */
            ii(0x1009_0530, 4);  mov(memw[ss, ebp - 78], ax);          /* mov [ebp-0x4e], ax */
        l_0x1009_0534:
            ii(0x1009_0534, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_0537, 3);  cmp(memb[ds, eax], 0);                /* cmp byte [eax], 0x0 */
            ii(0x1009_053a, 2);  if(jz(0x1009_0552, 0x16)) goto l_0x1009_0552;/* jz 0x10090552 */
            ii(0x1009_053c, 4);  movsx(eax, memw[ss, ebp - 76]);       /* movsx eax, word [ebp-0x4c] */
            ii(0x1009_0540, 3);  lea(edx, memd[ds, eax + 1]);          /* lea edx, [eax+0x1] */
            ii(0x1009_0543, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_0546, 3);  mov(eax, memd[ds, eax + 29]);         /* mov eax, [eax+0x1d] */
            ii(0x1009_0549, 5);  call(Definitions.my_min, -0x6dca);    /* call 0x10089784 */
            ii(0x1009_054e, 4);  mov(memw[ss, ebp - 76], ax);          /* mov [ebp-0x4c], ax */
        l_0x1009_0552:
            ii(0x1009_0552, 4);  movsx(edx, memw[ss, ebp - 80]);       /* movsx edx, word [ebp-0x50] */
            ii(0x1009_0556, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_0559, 3);  cmp(edx, memd[ds, eax + 17]);         /* cmp edx, [eax+0x11] */
            ii(0x1009_055c, 6);  if(jle(0x1009_0670, 0x10e)) goto l_0x1009_0670;/* jle 0x10090670 */
            ii(0x1009_0562, 3);  mov(eax, memd[ss, ebp - 80]);         /* mov eax, [ebp-0x50] */
            ii(0x1009_0565, 1);  dec(eax);                             /* dec eax */
            ii(0x1009_0566, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_0569, 3);  mov(memw[ds, edx], ax);               /* mov [edx], ax */
            ii(0x1009_056c, 3);  mov(eax, memd[ss, ebp - 78]);         /* mov eax, [ebp-0x4e] */
            ii(0x1009_056f, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_0572, 4);  mov(memw[ds, edx + 2], ax);           /* mov [edx+0x2], ax */
        l_0x1009_0576:
            ii(0x1009_0576, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_0579, 4);  mov(ax, memw[ds, eax + 2]);           /* mov ax, [eax+0x2] */
            ii(0x1009_057d, 4);  cmp(ax, memw[ss, ebp - 76]);          /* cmp ax, [ebp-0x4c] */
            ii(0x1009_0581, 6);  if(jge(0x1009_0670, 0xe9)) goto l_0x1009_0670;/* jge 0x10090670 */
            ii(0x1009_0587, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_058a, 3);  mov(memd[ss, ebp - 84], eax);         /* mov [ebp-0x54], eax */
            ii(0x1009_058d, 3);  mov(eax, memd[ss, ebp - 84]);         /* mov eax, [ebp-0x54] */
            ii(0x1009_0590, 3);  mov(ecx, memd[ds, eax + 35]);         /* mov ecx, [eax+0x23] */
            ii(0x1009_0593, 4);  movsx(ebx, memw[ss, ebp - 76]);       /* movsx ebx, word [ebp-0x4c] */
            ii(0x1009_0597, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_059a, 3);  lea(eax, memd[ss, ebp - 88]);         /* lea eax, [ebp-0x58] */
            ii(0x1009_059d, 5);  call(0x1007_5e64, -0x1_a73e);         /* call 0x10075e64 */
            ii(0x1009_05a2, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_05a4, 3);  mov(eax, memd[ss, ebp - 84]);         /* mov eax, [ebp-0x54] */
            ii(0x1009_05a7, 3);  call_abs(memd[ds, ecx + 8]);          /* call dword [ecx+0x8] */
            ii(0x1009_05aa, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_05ac, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_05af, 4);  mov(memw[ds, eax + 2], dx);           /* mov [eax+0x2], dx */
            ii(0x1009_05b3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_05b6, 4);  mov(ax, memw[ds, eax + 2]);           /* mov ax, [eax+0x2] */
            ii(0x1009_05ba, 4);  cmp(ax, memw[ss, ebp - 76]);          /* cmp ax, [ebp-0x4c] */
            ii(0x1009_05be, 6);  if(jge(0x1009_066b, 0xa7)) goto l_0x1009_066b;/* jge 0x1009066b */
            ii(0x1009_05c4, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_05c7, 3);  mov(ax, memw[ds, eax]);               /* mov ax, [eax] */
            ii(0x1009_05ca, 4);  mov(memw[ss, ebp - 96], ax);          /* mov [ebp-0x60], ax */
            ii(0x1009_05ce, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_05d1, 3);  mov(memd[ss, ebp - 100], eax);        /* mov [ebp-0x64], eax */
            ii(0x1009_05d4, 3);  mov(eax, memd[ss, ebp - 100]);        /* mov eax, [ebp-0x64] */
            ii(0x1009_05d7, 3);  mov(esi, memd[ds, eax + 35]);         /* mov esi, [eax+0x23] */
            ii(0x1009_05da, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_05dd, 3);  mov(ebx, memd[ds, eax + 19]);         /* mov ebx, [eax+0x13] */
            ii(0x1009_05e0, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1009_05e3, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_05e6, 3);  lea(eax, memd[ss, ebp - 104]);        /* lea eax, [ebp-0x68] */
            ii(0x1009_05e9, 5);  call(0x1007_5e64, -0x1_a78a);         /* call 0x10075e64 */
            ii(0x1009_05ee, 3);  mov(ecx, memd[ss, ebp - 100]);        /* mov ecx, [ebp-0x64] */
            ii(0x1009_05f1, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_05f3, 2);  mov(eax, ecx);                        /* mov eax, ecx */
            ii(0x1009_05f5, 2);  call_abs(memd[ds, esi]);              /* call dword [esi] */
            ii(0x1009_05f7, 4);  mov(memw[ss, ebp - 94], ax);          /* mov [ebp-0x5e], ax */
            ii(0x1009_05fb, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_05fe, 3);  mov(memd[ss, ebp - 108], eax);        /* mov [ebp-0x6c], eax */
            ii(0x1009_0601, 3);  mov(eax, memd[ss, ebp - 108]);        /* mov eax, [ebp-0x6c] */
            ii(0x1009_0604, 3);  mov(ecx, memd[ds, eax + 35]);         /* mov ecx, [eax+0x23] */
            ii(0x1009_0607, 3);  mov(ebx, memd[ss, ebp - 8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1009_060a, 3);  mov(ebx, memd[ds, ebx + 27]);         /* mov ebx, [ebx+0x1b] */
            ii(0x1009_060d, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1009_0610, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_0613, 3);  lea(eax, memd[ss, ebp - 112]);        /* lea eax, [ebp-0x70] */
            ii(0x1009_0616, 5);  call(0x1007_5e64, -0x1_a7b7);         /* call 0x10075e64 */
            ii(0x1009_061b, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_061d, 3);  mov(eax, memd[ss, ebp - 108]);        /* mov eax, [ebp-0x6c] */
            ii(0x1009_0620, 3);  call_abs(memd[ds, ecx + 4]);          /* call dword [ecx+0x4] */
            ii(0x1009_0623, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_0626, 4);  mov(memw[ds, edx + 2], ax);           /* mov [edx+0x2], ax */
            ii(0x1009_062a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_062d, 4);  mov(ax, memw[ds, eax + 2]);           /* mov ax, [eax+0x2] */
            ii(0x1009_0631, 4);  mov(memw[ss, ebp - 92], ax);          /* mov [ebp-0x5c], ax */
            ii(0x1009_0635, 3);  mov(eax, memd[ss, ebp - 92]);         /* mov eax, [ebp-0x5c] */
            ii(0x1009_0638, 3);  sub(eax, memd[ss, ebp - 94]);         /* sub eax, [ebp-0x5e] */
            ii(0x1009_063b, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1009_063e, 4);  add(memw[ds, edx + 33], ax);          /* add [edx+0x21], ax */
            ii(0x1009_0642, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_0645, 3);  mov(memd[ss, ebp - 116], eax);        /* mov [ebp-0x74], eax */
            ii(0x1009_0648, 3);  mov(esi, memd[ss, ebp - 116]);        /* mov esi, [ebp-0x74] */
            ii(0x1009_064b, 3);  mov(esi, memd[ds, esi + 35]);         /* mov esi, [esi+0x23] */
            ii(0x1009_064e, 4);  movsx(ecx, memw[ss, ebp - 92]);       /* movsx ecx, word [ebp-0x5c] */
            ii(0x1009_0652, 4);  movsx(ebx, memw[ss, ebp - 94]);       /* movsx ebx, word [ebp-0x5e] */
            ii(0x1009_0656, 4);  movsx(edx, memw[ss, ebp - 96]);       /* movsx edx, word [ebp-0x60] */
            ii(0x1009_065a, 3);  mov(eax, memd[ss, ebp - 116]);        /* mov eax, [ebp-0x74] */
            ii(0x1009_065d, 3);  call_abs(memd[ds, esi + 12]);         /* call dword [esi+0xc] */
            ii(0x1009_0660, 3);  lea(edx, memd[ss, ebp - 96]);         /* lea edx, [ebp-0x60] */
            ii(0x1009_0663, 3);  lea(eax, memd[ss, ebp - 72]);         /* lea eax, [ebp-0x48] */
            ii(0x1009_0666, 5);  call(0x1009_c18c, 0xbb21);            /* call 0x1009c18c */
        l_0x1009_066b:
            ii(0x1009_066b, 5);  jmp(0x1009_0576, -0xfa); goto l_0x1009_0576;/* jmp 0x10090576 */
        l_0x1009_0670:
            ii(0x1009_0670, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_0673, 3);  mov(eax, memd[ds, eax + 25]);         /* mov eax, [eax+0x19] */
            ii(0x1009_0676, 1);  dec(eax);                             /* dec eax */
            ii(0x1009_0677, 4);  movsx(edx, memw[ss, ebp - 80]);       /* movsx edx, word [ebp-0x50] */
            ii(0x1009_067b, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1009_067d, 6);  if(jge(0x1009_07a9, 0x126)) goto l_0x1009_07a9;/* jge 0x100907a9 */
            ii(0x1009_0683, 3);  mov(eax, memd[ss, ebp - 80]);         /* mov eax, [ebp-0x50] */
            ii(0x1009_0686, 1);  inc(eax);                             /* inc eax */
            ii(0x1009_0687, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_068a, 3);  mov(memw[ds, edx], ax);               /* mov [edx], ax */
            ii(0x1009_068d, 3);  mov(eax, memd[ss, ebp - 78]);         /* mov eax, [ebp-0x4e] */
            ii(0x1009_0690, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_0693, 4);  mov(memw[ds, edx + 2], ax);           /* mov [edx+0x2], ax */
        l_0x1009_0697:
            ii(0x1009_0697, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_069a, 4);  mov(ax, memw[ds, eax + 2]);           /* mov ax, [eax+0x2] */
            ii(0x1009_069e, 4);  cmp(ax, memw[ss, ebp - 76]);          /* cmp ax, [ebp-0x4c] */
            ii(0x1009_06a2, 6);  if(jge(0x1009_07a9, 0x101)) goto l_0x1009_07a9;/* jge 0x100907a9 */
            ii(0x1009_06a8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_06ab, 3);  mov(memd[ss, ebp - 120], eax);        /* mov [ebp-0x78], eax */
            ii(0x1009_06ae, 3);  mov(eax, memd[ss, ebp - 120]);        /* mov eax, [ebp-0x78] */
            ii(0x1009_06b1, 3);  mov(ecx, memd[ds, eax + 35]);         /* mov ecx, [eax+0x23] */
            ii(0x1009_06b4, 4);  movsx(ebx, memw[ss, ebp - 76]);       /* movsx ebx, word [ebp-0x4c] */
            ii(0x1009_06b8, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_06bb, 3);  lea(eax, memd[ss, ebp - 124]);        /* lea eax, [ebp-0x7c] */
            ii(0x1009_06be, 5);  call(0x1007_5e64, -0x1_a85f);         /* call 0x10075e64 */
            ii(0x1009_06c3, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_06c5, 3);  mov(eax, memd[ss, ebp - 120]);        /* mov eax, [ebp-0x78] */
            ii(0x1009_06c8, 3);  call_abs(memd[ds, ecx + 8]);          /* call dword [ecx+0x8] */
            ii(0x1009_06cb, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_06cd, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_06d0, 4);  mov(memw[ds, eax + 2], dx);           /* mov [eax+0x2], dx */
            ii(0x1009_06d4, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_06d7, 4);  mov(ax, memw[ds, eax + 2]);           /* mov ax, [eax+0x2] */
            ii(0x1009_06db, 4);  cmp(ax, memw[ss, ebp - 76]);          /* cmp ax, [ebp-0x4c] */
            ii(0x1009_06df, 6);  if(jge(0x1009_07a4, 0xbf)) goto l_0x1009_07a4;/* jge 0x100907a4 */
            ii(0x1009_06e5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_06e8, 3);  mov(ax, memw[ds, eax]);               /* mov ax, [eax] */
            ii(0x1009_06eb, 4);  mov(memw[ss, ebp - 96], ax);          /* mov [ebp-0x60], ax */
            ii(0x1009_06ef, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_06f2, 3);  mov(memd[ss, ebp - 128], eax);        /* mov [ebp-0x80], eax */
            ii(0x1009_06f5, 3);  mov(eax, memd[ss, ebp - 128]);        /* mov eax, [ebp-0x80] */
            ii(0x1009_06f8, 3);  mov(esi, memd[ds, eax + 35]);         /* mov esi, [eax+0x23] */
            ii(0x1009_06fb, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_06fe, 3);  mov(ebx, memd[ds, eax + 19]);         /* mov ebx, [eax+0x13] */
            ii(0x1009_0701, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1009_0704, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_0707, 6);  lea(eax, memd[ss, ebp - 132]);        /* lea eax, [ebp-0x84] */
            ii(0x1009_070d, 5);  call(0x1007_5e64, -0x1_a8ae);         /* call 0x10075e64 */
            ii(0x1009_0712, 3);  mov(ecx, memd[ss, ebp - 128]);        /* mov ecx, [ebp-0x80] */
            ii(0x1009_0715, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_0717, 2);  mov(eax, ecx);                        /* mov eax, ecx */
            ii(0x1009_0719, 2);  call_abs(memd[ds, esi]);              /* call dword [esi] */
            ii(0x1009_071b, 4);  mov(memw[ss, ebp - 94], ax);          /* mov [ebp-0x5e], ax */
            ii(0x1009_071f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_0722, 6);  mov(memd[ss, ebp - 136], eax);        /* mov [ebp-0x88], eax */
            ii(0x1009_0728, 6);  mov(eax, memd[ss, ebp - 136]);        /* mov eax, [ebp-0x88] */
            ii(0x1009_072e, 3);  mov(ecx, memd[ds, eax + 35]);         /* mov ecx, [eax+0x23] */
            ii(0x1009_0731, 3);  mov(ebx, memd[ss, ebp - 8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1009_0734, 3);  mov(ebx, memd[ds, ebx + 27]);         /* mov ebx, [ebx+0x1b] */
            ii(0x1009_0737, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1009_073a, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_073d, 6);  lea(eax, memd[ss, ebp - 140]);        /* lea eax, [ebp-0x8c] */
            ii(0x1009_0743, 5);  call(0x1007_5e64, -0x1_a8e4);         /* call 0x10075e64 */
            ii(0x1009_0748, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_074a, 6);  mov(eax, memd[ss, ebp - 136]);        /* mov eax, [ebp-0x88] */
            ii(0x1009_0750, 3);  call_abs(memd[ds, ecx + 4]);          /* call dword [ecx+0x4] */
            ii(0x1009_0753, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_0756, 4);  mov(memw[ds, edx + 2], ax);           /* mov [edx+0x2], ax */
            ii(0x1009_075a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_075d, 4);  mov(ax, memw[ds, eax + 2]);           /* mov ax, [eax+0x2] */
            ii(0x1009_0761, 4);  mov(memw[ss, ebp - 92], ax);          /* mov [ebp-0x5c], ax */
            ii(0x1009_0765, 3);  mov(eax, memd[ss, ebp - 92]);         /* mov eax, [ebp-0x5c] */
            ii(0x1009_0768, 3);  sub(eax, memd[ss, ebp - 94]);         /* sub eax, [ebp-0x5e] */
            ii(0x1009_076b, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1009_076e, 4);  add(memw[ds, edx + 33], ax);          /* add [edx+0x21], ax */
            ii(0x1009_0772, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_0775, 6);  mov(memd[ss, ebp - 144], eax);        /* mov [ebp-0x90], eax */
            ii(0x1009_077b, 6);  mov(esi, memd[ss, ebp - 144]);        /* mov esi, [ebp-0x90] */
            ii(0x1009_0781, 3);  mov(esi, memd[ds, esi + 35]);         /* mov esi, [esi+0x23] */
            ii(0x1009_0784, 4);  movsx(ecx, memw[ss, ebp - 92]);       /* movsx ecx, word [ebp-0x5c] */
            ii(0x1009_0788, 4);  movsx(ebx, memw[ss, ebp - 94]);       /* movsx ebx, word [ebp-0x5e] */
            ii(0x1009_078c, 4);  movsx(edx, memw[ss, ebp - 96]);       /* movsx edx, word [ebp-0x60] */
            ii(0x1009_0790, 6);  mov(eax, memd[ss, ebp - 144]);        /* mov eax, [ebp-0x90] */
            ii(0x1009_0796, 3);  call_abs(memd[ds, esi + 12]);         /* call dword [esi+0xc] */
            ii(0x1009_0799, 3);  lea(edx, memd[ss, ebp - 96]);         /* lea edx, [ebp-0x60] */
            ii(0x1009_079c, 3);  lea(eax, memd[ss, ebp - 72]);         /* lea eax, [ebp-0x48] */
            ii(0x1009_079f, 5);  call(0x1009_c18c, 0xb9e8);            /* call 0x1009c18c */
        l_0x1009_07a4:
            ii(0x1009_07a4, 5);  jmp(0x1009_0697, -0x112); goto l_0x1009_0697;/* jmp 0x10090697 */
        l_0x1009_07a9:
            ii(0x1009_07a9, 5);  jmp(0x1009_046d, -0x341); goto l_0x1009_046d;/* jmp 0x1009046d */
        l_0x1009_07ae:
            ii(0x1009_07ae, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_07b1, 3);  inc(memd[ds, eax + 9]);               /* inc dword [eax+0x9] */
            ii(0x1009_07b4, 3);  mov(eax, memd[ss, ebp - 52]);         /* mov eax, [ebp-0x34] */
            ii(0x1009_07b7, 5);  call(0x1014_85ad, 0xb_7df1);          /* call 0x101485ad */
            ii(0x1009_07bc, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1009_07bf, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1009_07c3, 3);  cmp(eax, 0xa);                        /* cmp eax, 0xa */
            ii(0x1009_07c6, 2);  if(jg(0x1009_07cf, 7)) goto l_0x1009_07cf;/* jg 0x100907cf */
            ii(0x1009_07c8, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1009_07cc, 3);  cmp(eax, 0xa);                        /* cmp eax, 0xa */
        l_0x1009_07cf:
            ii(0x1009_07cf, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_07d2, 4);  mov(ax, memw[ds, eax + 33]);          /* mov ax, [eax+0x21] */
            ii(0x1009_07d6, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1009_07d9, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_07db, 3);  lea(eax, memd[ss, ebp - 72]);         /* lea eax, [ebp-0x48] */
            ii(0x1009_07de, 5);  call(0x1009_c0e4, 0xb901);            /* call 0x1009c0e4 */
            ii(0x1009_07e3, 2);  jmp(0x1009_07ef, 0xa); goto l_0x1009_07ef;/* jmp 0x100907ef */
        //  ii(0x1009_07e5, 2);  xor(edx, edx);                        /* xor edx, edx */
        //  ii(0x1009_07e7, 3);  lea(eax, memd[ss, ebp - 72]);         /* lea eax, [ebp-0x48] */
        //  ii(0x1009_07ea, 5);  call(0x1009_c0e4, 0xb8f5);            /* call 0x1009c0e4 */
        l_0x1009_07ef:
            ii(0x1009_07ef, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1009_07f2, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_07f4, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_07f5, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_07f6, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_07f7, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_07f8, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_07f9, 1);  ret();                                /* ret */
        }
    }
}
