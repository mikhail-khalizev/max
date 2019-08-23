using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_0803-af830b80")]
        public void Method_100d_0803()
        {
            ii(0x100d_0803, 5); push(0x58);                             /* push 0x58 */
            ii(0x100d_0808, 5); call(Definitions.sys_check_available_stack_size, 0x9_5545); /* call 0x10165d52 */
            ii(0x100d_080d, 1); push(ebx);                              /* push ebx */
            ii(0x100d_080e, 1); push(ecx);                              /* push ecx */
            ii(0x100d_080f, 1); push(edx);                              /* push edx */
            ii(0x100d_0810, 1); push(esi);                              /* push esi */
            ii(0x100d_0811, 1); push(edi);                              /* push edi */
            ii(0x100d_0812, 1); push(ebp);                              /* push ebp */
            ii(0x100d_0813, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_0815, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x100d_081b, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100d_081e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_0821, 4); mov(ax, memw[ds, eax + 0xc]);           /* mov ax, [eax+0xc] */
            ii(0x100d_0825, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100d_0828, 4); sub(ax, memw[ds, edx + 0x4]);           /* sub ax, [edx+0x4] */
            ii(0x100d_082c, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100d_082f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_0832, 3); mov(eax, memd[ds, eax + 0x12]);         /* mov eax, [eax+0x12] */
            ii(0x100d_0835, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_0838, 1); push(eax);                              /* push eax */
            ii(0x100d_0839, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_083c, 3); push(memd[ds, eax + 0x1a]);             /* push dword [eax+0x1a] */
            ii(0x100d_083f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_0842, 3); mov(eax, memd[ds, eax + 0x2a]);         /* mov eax, [eax+0x2a] */
            ii(0x100d_0845, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100d_0848, 1); push(eax);                              /* push eax */
            ii(0x100d_0849, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_084c, 3); mov(eax, memd[ds, eax + 0x2a]);         /* mov eax, [eax+0x2a] */
            ii(0x100d_084f, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100d_0851, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_0854, 1); push(eax);                              /* push eax */
            ii(0x100d_0855, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_0858, 3); mov(eax, memd[ds, eax + 0x2a]);         /* mov eax, [eax+0x2a] */
            ii(0x100d_085b, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100d_085e, 1); push(eax);                              /* push eax */
            ii(0x100d_085f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_0862, 3); mov(eax, memd[ds, eax + 0x2a]);         /* mov eax, [eax+0x2a] */
            ii(0x100d_0865, 3); add(eax, 0x8);                          /* add eax, 0x8 */
            ii(0x100d_0868, 1); push(eax);                              /* push eax */
            ii(0x100d_0869, 5); call(/* sys */ 0x1016_abbc, 0x9_a34e);  /* call 0x1016abbc */
            ii(0x100d_086e, 3); add(esp, 0x18);                         /* add esp, 0x18 */
            ii(0x100d_0871, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x100d_0876, 5); call(/* sys */ 0x1016_a24c, 0x9_99d1);  /* call 0x1016a24c */
            ii(0x100d_087b, 7); mov(memd[ss, ebp - 0x8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x100d_0882, 2); jmp(0x100d_088a, 0x6); goto l_0x100d_088a; /* jmp 0x100d088a */
        l_0x100d_0884:
            ii(0x100d_0884, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0887, 3); inc(memd[ss, ebp - 0x8]);               /* inc dword [ebp-0x8] */
        l_0x100d_088a:
            ii(0x100d_088a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_088d, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100d_0890, 4); cmp(ax, memw[ds, edx + 0x28]);          /* cmp ax, [edx+0x28] */
            ii(0x100d_0894, 2); if(jge(0x100d_08b5, 0x1f)) goto l_0x100d_08b5; /* jge 0x100d08b5 */
            ii(0x100d_0896, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_0899, 3); mov(eax, memd[ds, eax + 0x22]);         /* mov eax, [eax+0x22] */
            ii(0x100d_089c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_089f, 4); movsx(edx, memw[ss, ebp - 0x8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100d_08a3, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100d_08a5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_08a8, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100d_08ab, 5); call(Definitions.my_2_get_count, -0x4_5548); /* call 0x1008b368 */
            ii(0x100d_08b0, 1); cwde();                                 /* cwde */
            ii(0x100d_08b1, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100d_08b3, 2); if(jl(0x100d_08b7, 0x2)) goto l_0x100d_08b7; /* jl 0x100d08b7 */
        l_0x100d_08b5:
            ii(0x100d_08b5, 2); jmp(0x100d_08fd, 0x46); goto l_0x100d_08fd; /* jmp 0x100d08fd */
        l_0x100d_08b7:
            ii(0x100d_08b7, 5); mov(eax, 0xa2);                         /* mov eax, 0xa2 */
            ii(0x100d_08bc, 1); push(eax);                              /* push eax */
            ii(0x100d_08bd, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x100d_08c1, 1); push(eax);                              /* push eax */
            ii(0x100d_08c2, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_08c5, 3); shl(eax, 0x5);                          /* shl eax, 0x5 */
            ii(0x100d_08c8, 1); cwde();                                 /* cwde */
            ii(0x100d_08c9, 1); push(eax);                              /* push eax */
            ii(0x100d_08ca, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100d_08cc, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_08cf, 4); mov(ax, memw[ds, eax + 0x24]);          /* mov ax, [eax+0x24] */
            ii(0x100d_08d3, 3); add(eax, memd[ss, ebp - 0x8]);          /* add eax, [ebp-0x8] */
            ii(0x100d_08d6, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_08d9, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_08dc, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100d_08df, 5); call(0x1008_b228, -0x4_56bc);           /* call 0x1008b228 */
            ii(0x100d_08e4, 3); movsx(ebx, memw[ds, eax]);              /* movsx ebx, word [eax] */
            ii(0x100d_08e7, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_08ea, 3); mov(edx, memd[ds, eax + 0x12]);         /* mov edx, [eax+0x12] */
            ii(0x100d_08ed, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_08f0, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_08f3, 3); mov(eax, memd[ds, eax + 0x1a]);         /* mov eax, [eax+0x1a] */
            ii(0x100d_08f6, 5); call(0x1012_b7dc, 0x5_aee1);            /* call 0x1012b7dc */
            ii(0x100d_08fb, 2); jmp(0x100d_0884, -0x79); goto l_0x100d_0884; /* jmp 0x100d0884 */
        l_0x100d_08fd:
            ii(0x100d_08fd, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_0900, 4); mov(dx, memw[ds, eax + 0x26]);          /* mov dx, [eax+0x26] */
            ii(0x100d_0904, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_0907, 4); cmp(dx, memw[ds, eax + 0x24]);          /* cmp dx, [eax+0x24] */
            ii(0x100d_090b, 2); if(jl(0x100d_092e, 0x21)) goto l_0x100d_092e; /* jl 0x100d092e */
            ii(0x100d_090d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_0910, 3); mov(edx, memd[ds, eax + 0x22]);         /* mov edx, [eax+0x22] */
            ii(0x100d_0913, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_0916, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_0919, 3); mov(eax, memd[ds, eax + 0x26]);         /* mov eax, [eax+0x26] */
            ii(0x100d_091c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_091f, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100d_0921, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_0924, 3); mov(eax, memd[ds, eax + 0x24]);         /* mov eax, [eax+0x24] */
            ii(0x100d_0927, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_092a, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x100d_092c, 2); if(jl(0x100d_0933, 0x5)) goto l_0x100d_0933; /* jl 0x100d0933 */
        l_0x100d_092e:
            ii(0x100d_092e, 5); jmp(0x100d_09d6, 0xa3); goto l_0x100d_09d6; /* jmp 0x100d09d6 */
        l_0x100d_0933:
            ii(0x100d_0933, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_0936, 3); mov(edx, memd[ds, eax + 0x24]);         /* mov edx, [eax+0x24] */
            ii(0x100d_0939, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_093c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_093f, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100d_0942, 5); call(0x1008_b228, -0x4_571f);           /* call 0x1008b228 */
            ii(0x100d_0947, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100d_094a, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100d_094d, 5); mov(edx, 0x101c_81c0);                  /* mov edx, 0x101c81c0 */
            ii(0x100d_0952, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100d_0954, 3); mov(memd[ss, ebp - 0x10], edx);         /* mov [ebp-0x10], edx */
            ii(0x100d_0957, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_095a, 4); mov(ax, memw[ds, eax + 0x26]);          /* mov ax, [eax+0x26] */
            ii(0x100d_095e, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100d_0961, 4); sub(ax, memw[ds, edx + 0x24]);          /* sub ax, [edx+0x24] */
            ii(0x100d_0965, 3); shl(eax, 0x5);                          /* shl eax, 0x5 */
            ii(0x100d_0968, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100d_096b, 5); call(0x100d_50b4, 0x4744);              /* call 0x100d50b4 */
            ii(0x100d_0970, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100d_0975, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100d_0978, 3); push(memd[ss, ebp - 0x18]);             /* push dword [ebp-0x18] */
            ii(0x100d_097b, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_097e, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100d_0980, 3); and(eax, 0x10);                         /* and eax, 0x10 */
            ii(0x100d_0983, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100d_0986, 3); push(memd[ss, ebp - 0x1c]);             /* push dword [ebp-0x1c] */
            ii(0x100d_0989, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_098c, 3); test(memb[ds, eax], 0x10);              /* test byte [eax], 0x10 */
            ii(0x100d_098f, 2); if(jz(0x100d_099a, 0x9)) goto l_0x100d_099a; /* jz 0x100d099a */
            ii(0x100d_0991, 7); mov(memd[ss, ebp - 0x20], 0x4_0000);    /* mov dword [ebp-0x20], 0x40000 */
            ii(0x100d_0998, 2); jmp(0x100d_09a1, 0x7); goto l_0x100d_09a1; /* jmp 0x100d09a1 */
        l_0x100d_099a:
            ii(0x100d_099a, 7); mov(memd[ss, ebp - 0x20], 0x2_0000);    /* mov dword [ebp-0x20], 0x20000 */
        l_0x100d_09a1:
            ii(0x100d_09a1, 3); push(memd[ss, ebp - 0x20]);             /* push dword [ebp-0x20] */
            ii(0x100d_09a4, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_09a7, 5); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x100d_09ac, 1); cwde();                                 /* cwde */
            ii(0x100d_09ad, 1); push(eax);                              /* push eax */
            ii(0x100d_09ae, 5); mov(eax, 0x20);                         /* mov eax, 0x20 */
            ii(0x100d_09b3, 1); push(eax);                              /* push eax */
            ii(0x100d_09b4, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x100d_09b8, 1); push(eax);                              /* push eax */
            ii(0x100d_09b9, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_09bb, 1); push(eax);                              /* push eax */
            ii(0x100d_09bc, 4); movsx(ecx, memw[ss, ebp - 0x14]);       /* movsx ecx, word [ebp-0x14] */
            ii(0x100d_09c0, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100d_09c2, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_09c5, 3); mov(edx, memd[ds, eax + 0x12]);         /* mov edx, [eax+0x12] */
            ii(0x100d_09c8, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_09cb, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_09ce, 3); mov(eax, memd[ds, eax + 0x1a]);         /* mov eax, [eax+0x1a] */
            ii(0x100d_09d1, 5); call(0x1010_2273, 0x3_189d);            /* call 0x10102273 */
        l_0x100d_09d6:
            ii(0x100d_09d6, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_09d9, 3); mov(eax, memd[ds, eax + 0x22]);         /* mov eax, [eax+0x22] */
            ii(0x100d_09dc, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_09df, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_09e1, 2); if(jle(0x100d_0a02, 0x1f)) goto l_0x100d_0a02; /* jle 0x100d0a02 */
            ii(0x100d_09e3, 5); call(0x100d_51e4, 0x47fc);              /* call 0x100d51e4 */
            ii(0x100d_09e8, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100d_09ea, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100d_09ec, 5); call(0x100d_5204, 0x4813);              /* call 0x100d5204 */
            ii(0x100d_09f1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_09f3, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100d_09f5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_09f8, 3); mov(eax, memd[ds, eax + 0x38]);         /* mov eax, [eax+0x38] */
            ii(0x100d_09fb, 5); call(0x100c_fa7c, -0xf84);              /* call 0x100cfa7c */
            ii(0x100d_0a00, 2); jmp(0x100d_0a16, 0x14); goto l_0x100d_0a16; /* jmp 0x100d0a16 */
        l_0x100d_0a02:
            ii(0x100d_0a02, 5); call(0x100d_51c4, 0x47bd);              /* call 0x100d51c4 */
            ii(0x100d_0a07, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_0a09, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100d_0a0b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_0a0e, 3); mov(eax, memd[ds, eax + 0x38]);         /* mov eax, [eax+0x38] */
            ii(0x100d_0a11, 5); call(0x100c_fb06, -0xf10);              /* call 0x100cfb06 */
        l_0x100d_0a16:
            ii(0x100d_0a16, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_0a19, 3); mov(edx, memd[ds, eax + 0x22]);         /* mov edx, [eax+0x22] */
            ii(0x100d_0a1c, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_0a1f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_0a22, 3); mov(eax, memd[ds, eax + 0x26]);         /* mov eax, [eax+0x26] */
            ii(0x100d_0a25, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_0a28, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100d_0a2a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_0a2d, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100d_0a30, 5); call(Definitions.my_2_get_count, -0x4_56cd); /* call 0x1008b368 */
            ii(0x100d_0a35, 1); cwde();                                 /* cwde */
            ii(0x100d_0a36, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100d_0a38, 2); if(jge(0x100d_0a59, 0x1f)) goto l_0x100d_0a59; /* jge 0x100d0a59 */
            ii(0x100d_0a3a, 5); call(0x100d_51e4, 0x47a5);              /* call 0x100d51e4 */
            ii(0x100d_0a3f, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100d_0a41, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100d_0a43, 5); call(0x100d_5204, 0x47bc);              /* call 0x100d5204 */
            ii(0x100d_0a48, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_0a4a, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100d_0a4c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_0a4f, 3); mov(eax, memd[ds, eax + 0x3c]);         /* mov eax, [eax+0x3c] */
            ii(0x100d_0a52, 5); call(0x100c_fa7c, -0xfdb);              /* call 0x100cfa7c */
            ii(0x100d_0a57, 2); jmp(0x100d_0a6d, 0x14); goto l_0x100d_0a6d; /* jmp 0x100d0a6d */
        l_0x100d_0a59:
            ii(0x100d_0a59, 5); call(0x100d_51c4, 0x4766);              /* call 0x100d51c4 */
            ii(0x100d_0a5e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_0a60, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100d_0a62, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_0a65, 3); mov(eax, memd[ds, eax + 0x3c]);         /* mov eax, [eax+0x3c] */
            ii(0x100d_0a68, 5); call(0x100c_fb06, -0xf67);              /* call 0x100cfb06 */
        l_0x100d_0a6d:
            ii(0x100d_0a6d, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100d_0a70, 3); add(edx, 0x4);                          /* add edx, 0x4 */
            ii(0x100d_0a73, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_0a76, 3); mov(eax, memd[ds, eax + 0x16]);         /* mov eax, [eax+0x16] */
            ii(0x100d_0a79, 5); call(Definitions.sys_display_draw_1, 0x9_6a2a); /* call 0x101674a8 */
            ii(0x100d_0a7e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_0a80, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_0a81, 1); pop(edi);                               /* pop edi */
            ii(0x100d_0a82, 1); pop(esi);                               /* pop esi */
            ii(0x100d_0a83, 1); pop(edx);                               /* pop edx */
            ii(0x100d_0a84, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_0a85, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_0a86, 1); ret();                                  /* ret */
        }
    }
}
