using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_df95-d61bbd5d")]
        public void Method_100c_df95()
        {
            ii(0x100c_df95, 5); push(0x40);                             /* push 0x40 */
            ii(0x100c_df9a, 5); call(Definitions.sys_check_available_stack_size, 0x9_7db3); /* call 0x10165d52 */
            ii(0x100c_df9f, 1); push(ebx);                              /* push ebx */
            ii(0x100c_dfa0, 1); push(ecx);                              /* push ecx */
            ii(0x100c_dfa1, 1); push(esi);                              /* push esi */
            ii(0x100c_dfa2, 1); push(edi);                              /* push edi */
            ii(0x100c_dfa3, 1); push(ebp);                              /* push ebp */
            ii(0x100c_dfa4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_dfa6, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x100c_dfac, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_dfaf, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100c_dfb2, 7); mov(memd[ss, ebp - 0x18], 0);           /* mov dword [ebp-0x18], 0x0 */
            ii(0x100c_dfb9, 4); or(memb[ss, ebp - 0xc], 1);             /* or byte [ebp-0xc], 0x1 */
            ii(0x100c_dfbd, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100c_dfc0, 5); call(0x100c_a02c, -0x3f99);             /* call 0x100ca02c */
            ii(0x100c_dfc5, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x100c_dfc8, 4); and(memb[ss, ebp - 0xc], -2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x100c_dfcc, 7); mov(memd[ss, ebp - 0x1c], 0x4b);        /* mov dword [ebp-0x1c], 0x4b */
        l_0x100c_dfd3:
            ii(0x100c_dfd3, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100c_dfd6, 4); cmp(ax, memw[ss, ebp - 0x1c]);          /* cmp ax, [ebp-0x1c] */
            ii(0x100c_dfda, 6); if(jge(0x100c_e064, 0x84)) goto l_0x100c_e064; /* jge 0x100ce064 */
            ii(0x100c_dfe0, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100c_dfe3, 3); inc(memd[ss, ebp - 0x18]);              /* inc dword [ebp-0x18] */
            ii(0x100c_dfe6, 1); cwde();                                 /* cwde */
            ii(0x100c_dfe7, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100c_dfe9, 7); mov(ax, memw[ds, eax + 0x101b_7b78]);   /* mov ax, [eax+0x101b7b78] */
            ii(0x100c_dff0, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_dff3, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100c_dff6, 3); inc(memd[ss, ebp - 0x18]);              /* inc dword [ebp-0x18] */
            ii(0x100c_dff9, 1); cwde();                                 /* cwde */
            ii(0x100c_dffa, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100c_dffc, 7); mov(ax, memw[ds, eax + 0x101b_7b78]);   /* mov ax, [eax+0x101b7b78] */
            ii(0x100c_e003, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100c_e006, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_e009, 4); cmp(ax, memw[ss, ebp - 4]);             /* cmp ax, [ebp-0x4] */
            ii(0x100c_e00d, 2); if(jnz(0x100c_e059, 0x4a)) goto l_0x100c_e059; /* jnz 0x100ce059 */
        l_0x100c_e00f:
            ii(0x100c_e00f, 3); dec(memd[ss, ebp - 0x14]);              /* dec dword [ebp-0x14] */
            ii(0x100c_e012, 5); cmp(memw[ss, ebp - 0x14], -1 /* 0xff */); /* cmp word [ebp-0x14], 0xffff */
            ii(0x100c_e017, 2); if(jz(0x100c_e039, 0x20)) goto l_0x100c_e039; /* jz 0x100ce039 */
            ii(0x100c_e019, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100c_e01c, 3); inc(memd[ss, ebp - 0x18]);              /* inc dword [ebp-0x18] */
            ii(0x100c_e01f, 1); cwde();                                 /* cwde */
            ii(0x100c_e020, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100c_e022, 7); mov(ax, memw[ds, eax + 0x101b_7b78]);   /* mov ax, [eax+0x101b7b78] */
            ii(0x100c_e029, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x100c_e02c, 3); lea(edx, memd[ss, ebp - 0x28]);         /* lea edx, [ebp-0x28] */
            ii(0x100c_e02f, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100c_e032, 5); call(0x1008_b2a8, -0x4_2d8f);           /* call 0x1008b2a8 */
            ii(0x100c_e037, 2); jmp(0x100c_e00f, -0x2a); goto l_0x100c_e00f; /* jmp 0x100ce00f */
        l_0x100c_e039:
            ii(0x100c_e039, 5); call(0x1009_cb74, -0x3_14ca);           /* call 0x1009cb74 */
            ii(0x100c_e03e, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_e040, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100c_e042, 3); lea(edx, memd[ss, ebp - 0x20]);         /* lea edx, [ebp-0x20] */
            ii(0x100c_e045, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_e048, 5); call(0x1009_cab0, -0x3_159d);           /* call 0x1009cab0 */
            ii(0x100c_e04d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_e04f, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100c_e052, 5); call(0x1008_8b04, -0x4_5553);           /* call 0x10088b04 */
            ii(0x100c_e057, 2); jmp(0x100c_e08e, 0x35); goto l_0x100c_e08e; /* jmp 0x100ce08e */
        l_0x100c_e059:
            ii(0x100c_e059, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_e05c, 3); add(memd[ss, ebp - 0x18], eax);         /* add [ebp-0x18], eax */
            ii(0x100c_e05f, 5); jmp(0x100c_dfd3, -0x91); goto l_0x100c_dfd3; /* jmp 0x100cdfd3 */
        l_0x100c_e064:
            ii(0x100c_e064, 5); call(0x1009_cb74, -0x3_14f5);           /* call 0x1009cb74 */
            ii(0x100c_e069, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_e06b, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100c_e06d, 3); lea(edx, memd[ss, ebp - 0x20]);         /* lea edx, [ebp-0x20] */
            ii(0x100c_e070, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_e073, 5); call(0x1009_cab0, -0x3_15c8);           /* call 0x1009cab0 */
            ii(0x100c_e078, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_e07a, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100c_e07d, 5); call(0x1008_8b04, -0x4_557e);           /* call 0x10088b04 */
            ii(0x100c_e082, 2); jmp(0x100c_e08e, 0xa); goto l_0x100c_e08e; /* jmp 0x100ce08e */
        //  ii(0x100c_e084, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x100c_e086, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
        //  ii(0x100c_e089, 5); call(0x1008_8b04, -0x4_558a);           /* call 0x10088b04 */
        l_0x100c_e08e:
            ii(0x100c_e08e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_e091, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_e093, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_e094, 1); pop(edi);                               /* pop edi */
            ii(0x100c_e095, 1); pop(esi);                               /* pop esi */
            ii(0x100c_e096, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_e097, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_e098, 1); ret();                                  /* ret */
        }
    }
}
