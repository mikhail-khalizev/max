using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_b338-e15faa5")]
        public void Method_1010_b338()
        {
            ii(0x1010_b338, 5); push(0x50);                             /* push 0x50 */
            ii(0x1010_b33d, 5); call(Definitions.sys_check_available_stack_size, 0x5_aa10); /* call 0x10165d52 */
            ii(0x1010_b342, 1); push(ebx);                              /* push ebx */
            ii(0x1010_b343, 1); push(ecx);                              /* push ecx */
            ii(0x1010_b344, 1); push(edx);                              /* push edx */
            ii(0x1010_b345, 1); push(esi);                              /* push esi */
            ii(0x1010_b346, 1); push(edi);                              /* push edi */
            ii(0x1010_b347, 1); push(ebp);                              /* push ebp */
            ii(0x1010_b348, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_b34a, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1010_b350, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_b353, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_b356, 3); mov(edx, memd[ds, eax + 0xd]);          /* mov edx, [eax+0xd] */
            ii(0x1010_b359, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_b35c, 6); mov(memd[ds, eax + 0x363], edx);        /* mov [eax+0x363], edx */
            ii(0x1010_b362, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_b365, 5); call(0x1010_a69d, -0xccd);              /* call 0x1010a69d */
            ii(0x1010_b36a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_b36d, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1010_b36f, 3); mov(eax, memd[ds, eax + 0x12]);         /* mov eax, [eax+0x12] */
            ii(0x1010_b372, 5); call(Definitions.sys_display_draw_0, 0x5_c10d); /* call 0x10167484 */
            ii(0x1010_b377, 5); mov(eax, 0x4a);                         /* mov eax, 0x4a */
            ii(0x1010_b37c, 5); call(0x1007_5fdc, -0x9_53a5);           /* call 0x10075fdc */
            ii(0x1010_b381, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1010_b384, 5); mov(eax, 0x4b);                         /* mov eax, 0x4b */
            ii(0x1010_b389, 5); call(0x1007_5fdc, -0x9_53b2);           /* call 0x10075fdc */
            ii(0x1010_b38e, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_b391, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_b394, 7); cmp(memd[ds, eax + 0x363], 0x2e);       /* cmp dword [eax+0x363], 0x2e */
            ii(0x1010_b39b, 2); if(jnz(0x1010_b3a5, 0x8)) goto l_0x1010_b3a5; /* jnz 0x1010b3a5 */
            ii(0x1010_b39d, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1010_b3a1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_b3a3, 2); if(jnz(0x1010_b3a7, 0x2)) goto l_0x1010_b3a7; /* jnz 0x1010b3a7 */
        l_0x1010_b3a5:
            ii(0x1010_b3a5, 2); jmp(0x1010_b3b0, 0x9); goto l_0x1010_b3b0; /* jmp 0x1010b3b0 */
        l_0x1010_b3a7:
            ii(0x1010_b3a7, 7); mov(memd[ss, ebp - 0x8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x1010_b3ae, 2); jmp(0x1010_b3ce, 0x1e); goto l_0x1010_b3ce; /* jmp 0x1010b3ce */
        l_0x1010_b3b0:
            ii(0x1010_b3b0, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_b3b3, 7); cmp(memd[ds, eax + 0x363], 0x2f);       /* cmp dword [eax+0x363], 0x2f */
            ii(0x1010_b3ba, 2); if(jnz(0x1010_b3c5, 0x9)) goto l_0x1010_b3c5; /* jnz 0x1010b3c5 */
            ii(0x1010_b3bc, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1010_b3c0, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1010_b3c3, 2); if(jnz(0x1010_b3c7, 0x2)) goto l_0x1010_b3c7; /* jnz 0x1010b3c7 */
        l_0x1010_b3c5:
            ii(0x1010_b3c5, 2); jmp(0x1010_b3ce, 0x7); goto l_0x1010_b3ce; /* jmp 0x1010b3ce */
        l_0x1010_b3c7:
            ii(0x1010_b3c7, 7); mov(memd[ss, ebp - 0x8], 0);            /* mov dword [ebp-0x8], 0x0 */
        l_0x1010_b3ce:
            ii(0x1010_b3ce, 5); mov(ebx, 0xa);                          /* mov ebx, 0xa */
            ii(0x1010_b3d3, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1010_b3d6, 6); add(edx, 0x345);                        /* add edx, 0x345 */
            ii(0x1010_b3dc, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1010_b3e0, 5); call(/* sys */ 0x1017_93f8, 0x6_e013);  /* call 0x101793f8 */
            ii(0x1010_b3e5, 5); mov(eax, 0x3a);                         /* mov eax, 0x3a */
            ii(0x1010_b3ea, 5); call(Definitions.sys_new, 0x5_aa11);    /* call 0x10165e00 */
            ii(0x1010_b3ef, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1010_b3f2, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_b3f5, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1010_b3f8, 4); cmp(memd[ss, ebp - 0x14], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1010_b3fc, 6); if(jz(0x1010_b4ab, 0xa9)) goto l_0x1010_b4ab; /* jz 0x1010b4ab */
            ii(0x1010_b402, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1010_b407, 1); push(eax);                              /* push eax */
            ii(0x1010_b408, 5); mov(eax, 0xa2);                         /* mov eax, 0xa2 */
            ii(0x1010_b40d, 1); push(eax);                              /* push eax */
            ii(0x1010_b40e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_b411, 7); imul(ecx, memd[ds, eax + 0x363], 0x18); /* imul ecx, [eax+0x363], 0x18 */
            ii(0x1010_b418, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_b41b, 7); imul(edx, memd[ds, eax + 0x363], 0x18); /* imul edx, [eax+0x363], 0x18 */
            ii(0x1010_b422, 7); mov(ax, memw[ds, ecx + 0x101b_a0ea]);   /* mov ax, [ecx+0x101ba0ea] */
            ii(0x1010_b429, 7); sub(ax, memw[ds, edx + 0x101b_a0e6]);   /* sub ax, [edx+0x101ba0e6] */
            ii(0x1010_b430, 1); cwde();                                 /* cwde */
            ii(0x1010_b431, 1); push(eax);                              /* push eax */
            ii(0x1010_b432, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_b435, 7); imul(edx, memd[ds, eax + 0x363], 0x18); /* imul edx, [eax+0x363], 0x18 */
            ii(0x1010_b43c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_b43f, 7); imul(ecx, memd[ds, eax + 0x363], 0x18); /* imul ecx, [eax+0x363], 0x18 */
            ii(0x1010_b446, 7); mov(ax, memw[ds, edx + 0x101b_a0e8]);   /* mov ax, [edx+0x101ba0e8] */
            ii(0x1010_b44d, 7); sub(ax, memw[ds, ecx + 0x101b_a0e4]);   /* sub ax, [ecx+0x101ba0e4] */
            ii(0x1010_b454, 3); sub(eax, 0x14);                         /* sub eax, 0x14 */
            ii(0x1010_b457, 1); cwde();                                 /* cwde */
            ii(0x1010_b458, 1); push(eax);                              /* push eax */
            ii(0x1010_b459, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_b45c, 7); imul(eax, memd[ds, eax + 0x363], 0x18); /* imul eax, [eax+0x363], 0x18 */
            ii(0x1010_b463, 6); mov(eax, memd[ds, eax + 0x101b_a0e4]);  /* mov eax, [eax+0x101ba0e4] */
            ii(0x1010_b469, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_b46c, 1); push(eax);                              /* push eax */
            ii(0x1010_b46d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_b470, 7); imul(eax, memd[ds, eax + 0x363], 0x18); /* imul eax, [eax+0x363], 0x18 */
            ii(0x1010_b477, 7); mov(ax, memw[ds, eax + 0x101b_a0e4]);   /* mov ax, [eax+0x101ba0e4] */
            ii(0x1010_b47e, 5); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1010_b483, 1); cwde();                                 /* cwde */
            ii(0x1010_b484, 1); push(eax);                              /* push eax */
            ii(0x1010_b485, 5); mov(ecx, 0x5);                          /* mov ecx, 0x5 */
            ii(0x1010_b48a, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1010_b48d, 6); add(ebx, 0x345);                        /* add ebx, 0x345 */
            ii(0x1010_b493, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_b496, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1010_b498, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_b49b, 5); call(0x100e_af58, -0x2_0548);           /* call 0x100eaf58 */
            ii(0x1010_b4a0, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1010_b4a3, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1010_b4a6, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1010_b4a9, 2); jmp(0x1010_b4b1, 0x6); goto l_0x1010_b4b1; /* jmp 0x1010b4b1 */
        l_0x1010_b4ab:
            ii(0x1010_b4ab, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1010_b4ae, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
        l_0x1010_b4b1:
            ii(0x1010_b4b1, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1010_b4b4, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1010_b4b7, 6); mov(memd[ds, edx + 0x341], eax);        /* mov [edx+0x341], eax */
            ii(0x1010_b4bd, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1010_b4c2, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_b4c5, 6); mov(eax, memd[ds, eax + 0x341]);        /* mov eax, [eax+0x341] */
            ii(0x1010_b4cb, 5); call(0x100d_60d4, -0x3_53fc);           /* call 0x100d60d4 */
            ii(0x1010_b4d0, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_b4d3, 6); mov(eax, memd[ds, eax + 0x341]);        /* mov eax, [eax+0x341] */
            ii(0x1010_b4d9, 5); call(0x100e_b180, -0x2_035e);           /* call 0x100eb180 */
            ii(0x1010_b4de, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1010_b4e1, 6); add(edx, 0x345);                        /* add edx, 0x345 */
            ii(0x1010_b4e7, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_b4ea, 6); mov(eax, memd[ds, eax + 0x341]);        /* mov eax, [eax+0x341] */
            ii(0x1010_b4f0, 5); call(0x100e_b14d, -0x2_03a8);           /* call 0x100eb14d */
            ii(0x1010_b4f5, 5); call(0x100d_6104, -0x3_53f6);           /* call 0x100d6104 */
            ii(0x1010_b4fa, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_b4fc, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1010_b4fe, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_b501, 6); mov(eax, memd[ds, eax + 0x341]);        /* mov eax, [eax+0x341] */
            ii(0x1010_b507, 5); call(0x100e_b5e1, -0x1_ff2b);           /* call 0x100eb5e1 */
            ii(0x1010_b50c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_b50f, 6); mov(eax, memd[ds, eax + 0x341]);        /* mov eax, [eax+0x341] */
            ii(0x1010_b515, 5); call(0x100e_b1b2, -0x2_0368);           /* call 0x100eb1b2 */
            ii(0x1010_b51a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_b51c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_b51d, 1); pop(edi);                               /* pop edi */
            ii(0x1010_b51e, 1); pop(esi);                               /* pop esi */
            ii(0x1010_b51f, 1); pop(edx);                               /* pop edx */
            ii(0x1010_b520, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_b521, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_b522, 1); ret();                                  /* ret */
        }
    }
}
