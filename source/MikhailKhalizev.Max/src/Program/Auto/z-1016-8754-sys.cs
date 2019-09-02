using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_8754-8f120fa6")]
        public void /* sys */ Method_1016_8754()
        {
            ii(0x1016_8754, 1); push(esi);                              /* push esi */
            ii(0x1016_8755, 1); push(edi);                              /* push edi */
            ii(0x1016_8756, 1); push(ebp);                              /* push ebp */
            ii(0x1016_8757, 3); sub(esp, 0x38);                         /* sub esp, 0x38 */
            ii(0x1016_875a, 4); mov(memd[ss, esp + 0x10], eax);         /* mov [esp+0x10], eax */
            ii(0x1016_875e, 4); mov(memd[ss, esp + 0x28], edx);         /* mov [esp+0x28], edx */
            ii(0x1016_8762, 4); mov(memd[ss, esp + 0x2c], ebx);         /* mov [esp+0x2c], ebx */
            ii(0x1016_8766, 3); mov(memd[ss, esp], ecx);                /* mov [esp], ecx */
            ii(0x1016_8769, 5); call(/* sys */ 0x1016_7dac, -0x9c2);    /* call 0x10167dac */
            ii(0x1016_876e, 6); mov(edx, memd[ds, 0x101b_ddbc]);        /* mov edx, [0x101bddbc] */
            ii(0x1016_8774, 4); mov(memd[ss, esp + 0x30], eax);         /* mov [esp+0x30], eax */
            ii(0x1016_8778, 4); mov(memd[ss, esp + 0x24], eax);         /* mov [esp+0x24], eax */
            ii(0x1016_877c, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1016_877e, 2); if(jz(0x1016_8784, 4)) goto l_0x1016_8784; /* jz 0x10168784 */
            ii(0x1016_8780, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_8782, 2); if(jnz(0x1016_878e, 0xa)) goto l_0x1016_878e; /* jnz 0x1016878e */
        l_0x1016_8784:
            ii(0x1016_8784, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1016_8789, 5); jmp(0x1016_8ab3, 0x325); goto l_0x1016_8ab3; /* jmp 0x10168ab3 */
        l_0x1016_878e:
            ii(0x1016_878e, 4); mov(eax, memd[ss, esp + 0x54]);         /* mov eax, [esp+0x54] */
            ii(0x1016_8792, 6); call_abs(memd[ds, 0x101b_ddf4]);        /* call dword [0x101bddf4] */ /* Вызов '0x1016_a4d0'. */
            ii(0x1016_8798, 3); lea(esi, memd[ds, eax + 0x10]);         /* lea esi, [eax+0x10] */
            ii(0x1016_879b, 6); call_abs(memd[ds, 0x101b_ddf0]);        /* call dword [0x101bddf0] */ /* Вызов '0x1016_a4c4'. */
            ii(0x1016_87a1, 3); lea(edi, memd[ds, eax + 6]);            /* lea edi, [eax+0x6] */
            ii(0x1016_87a4, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1016_87a6, 3); imul(edx, edi);                         /* imul edx, edi */
            ii(0x1016_87a9, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_87ab, 5); call(Definitions.sys_malloc_internal, 0x1_9b40); /* call 0x101822f0 */
            ii(0x1016_87b0, 2); mov(ebp, eax);                          /* mov ebp, eax */
            ii(0x1016_87b2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_87b4, 2); if(jnz(0x1016_87c4, 0xe)) goto l_0x1016_87c4; /* jnz 0x101687c4 */
            ii(0x1016_87b6, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1016_87bb, 3); add(esp, 0x38);                         /* add esp, 0x38 */
            ii(0x1016_87be, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_87bf, 1); pop(edi);                               /* pop edi */
            ii(0x1016_87c0, 1); pop(esi);                               /* pop esi */
            ii(0x1016_87c1, 3); ret(0x14); return;                      /* ret 0x14 */
        l_0x1016_87c4:
            ii(0x1016_87c4, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_87c6, 5); call(Definitions.sys_malloc_internal, 0x1_9b25); /* call 0x101822f0 */
            ii(0x1016_87cb, 4); mov(memd[ss, esp + 0x20], eax);         /* mov [esp+0x20], eax */
            ii(0x1016_87cf, 4); mov(memd[ss, esp + 0x34], eax);         /* mov [esp+0x34], eax */
            ii(0x1016_87d3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_87d5, 2); if(jnz(0x1016_87ec, 0x15)) goto l_0x1016_87ec; /* jnz 0x101687ec */
            ii(0x1016_87d7, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1016_87d9, 5); call(Definitions.sys_free_internal, 0x1_9c76); /* call 0x10182454 */
            ii(0x1016_87de, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1016_87e3, 3); add(esp, 0x38);                         /* add esp, 0x38 */
            ii(0x1016_87e6, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_87e7, 1); pop(edi);                               /* pop edi */
            ii(0x1016_87e8, 1); pop(esi);                               /* pop esi */
            ii(0x1016_87e9, 3); ret(0x14); return;                      /* ret 0x14 */
        l_0x1016_87ec:
            ii(0x1016_87ec, 4); mov(eax, memd[ss, esp + 0x30]);         /* mov eax, [esp+0x30] */
            ii(0x1016_87f0, 7); cmp(memd[ds, eax + 0x20], 0x100);       /* cmp dword [eax+0x20], 0x100 */
            ii(0x1016_87f7, 2); if(jnz(0x1016_8863, 0x6a)) goto l_0x1016_8863; /* jnz 0x10168863 */
            ii(0x1016_87f9, 7); cmp(memd[ds, 0x101c_b2e0], 0);          /* cmp dword [0x101cb2e0], 0x0 */
            ii(0x1016_8800, 2); if(jz(0x1016_8863, 0x61)) goto l_0x1016_8863; /* jz 0x10168863 */
            ii(0x1016_8802, 4); mov(ebx, memd[ss, esp + 0x2c]);         /* mov ebx, [esp+0x2c] */
            ii(0x1016_8806, 3); mov(eax, memd[ds, eax + 0x28]);         /* mov eax, [eax+0x28] */
            ii(0x1016_8809, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1016_880b, 1); inc(eax);                               /* inc eax */
            ii(0x1016_880c, 1); push(eax);                              /* push eax */
            ii(0x1016_880d, 4); mov(eax, memd[ss, esp + 0x34]);         /* mov eax, [esp+0x34] */
            ii(0x1016_8811, 4); mov(ecx, memd[ss, esp + 0x2c]);         /* mov ecx, [esp+0x2c] */
            ii(0x1016_8815, 3); mov(eax, memd[ds, eax + 0x24]);         /* mov eax, [eax+0x24] */
            ii(0x1016_8818, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1016_881a, 1); inc(eax);                               /* inc eax */
            ii(0x1016_881b, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1016_881d, 1); push(eax);                              /* push eax */
            ii(0x1016_881e, 5); mov(eax, memd[ds, 0x101c_b2e0]);        /* mov eax, [0x101cb2e0] */
            ii(0x1016_8823, 2); mov(ebx, edi);                          /* mov ebx, edi */
            ii(0x1016_8825, 1); push(eax);                              /* push eax */
            ii(0x1016_8826, 2); mov(ecx, esi);                          /* mov ecx, esi */
            ii(0x1016_8828, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1016_882a, 5); call(/* sys */ 0x1016_addc, 0x25ad);    /* call 0x1016addc */
            ii(0x1016_882f, 4); mov(eax, memd[ss, esp + 0x30]);         /* mov eax, [esp+0x30] */
            ii(0x1016_8833, 4); mov(edx, memd[ss, esp + 0x2c]);         /* mov edx, [esp+0x2c] */
            ii(0x1016_8837, 3); mov(eax, memd[ds, eax + 0x28]);         /* mov eax, [eax+0x28] */
            ii(0x1016_883a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1016_883c, 1); push(eax);                              /* push eax */
            ii(0x1016_883d, 4); mov(eax, memd[ss, esp + 0x34]);         /* mov eax, [esp+0x34] */
            ii(0x1016_8841, 4); mov(ebx, memd[ss, esp + 0x2c]);         /* mov ebx, [esp+0x2c] */
            ii(0x1016_8845, 3); mov(eax, memd[ds, eax + 0x24]);         /* mov eax, [eax+0x24] */
            ii(0x1016_8848, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1016_884a, 6); mov(ecx, memd[ds, 0x101c_b2e0]);        /* mov ecx, [0x101cb2e0] */
            ii(0x1016_8850, 1); push(eax);                              /* push eax */
            ii(0x1016_8851, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1016_8853, 2); mov(ebx, edi);                          /* mov ebx, edi */
            ii(0x1016_8855, 1); push(ecx);                              /* push ecx */
            ii(0x1016_8856, 4); mov(eax, memd[ss, esp + 0x2c]);         /* mov eax, [esp+0x2c] */
            ii(0x1016_885a, 2); mov(ecx, esi);                          /* mov ecx, esi */
            ii(0x1016_885c, 5); call(/* sys */ 0x1016_addc, 0x257b);    /* call 0x1016addc */
            ii(0x1016_8861, 2); jmp(0x1016_888f, 0x2c); goto l_0x1016_888f; /* jmp 0x1016888f */
        l_0x1016_8863:
            ii(0x1016_8863, 4); mov(eax, memd[ss, esp + 0x24]);         /* mov eax, [esp+0x24] */
            ii(0x1016_8867, 2); mov(ebx, edi);                          /* mov ebx, edi */
            ii(0x1016_8869, 3); mov(ecx, memd[ds, eax + 0x20]);         /* mov ecx, [eax+0x20] */
            ii(0x1016_886c, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1016_886e, 1); push(ecx);                              /* push ecx */
            ii(0x1016_886f, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1016_8871, 2); mov(ecx, esi);                          /* mov ecx, esi */
            ii(0x1016_8873, 5); call(/* sys */ 0x1016_ad78, 0x2500);    /* call 0x1016ad78 */
            ii(0x1016_8878, 4); mov(eax, memd[ss, esp + 0x24]);         /* mov eax, [esp+0x24] */
            ii(0x1016_887c, 2); mov(ecx, esi);                          /* mov ecx, esi */
            ii(0x1016_887e, 3); mov(edx, memd[ds, eax + 0x20]);         /* mov edx, [eax+0x20] */
            ii(0x1016_8881, 2); mov(ebx, edi);                          /* mov ebx, edi */
            ii(0x1016_8883, 1); push(edx);                              /* push edx */
            ii(0x1016_8884, 4); mov(eax, memd[ss, esp + 0x38]);         /* mov eax, [esp+0x38] */
            ii(0x1016_8888, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1016_888a, 5); call(/* sys */ 0x1016_ad78, 0x24e9);    /* call 0x1016ad78 */
        l_0x1016_888f:
            ii(0x1016_888f, 2); mov(ecx, esi);                          /* mov ecx, esi */
            ii(0x1016_8891, 2); mov(ebx, edi);                          /* mov ebx, edi */
            ii(0x1016_8893, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1016_8895, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1016_8897, 5); call(/* sys */ 0x1016_af44, 0x26a8);    /* call 0x1016af44 */
            ii(0x1016_889c, 5); mov(eax, memd[ds, 0x101b_ddcc]);        /* mov eax, [0x101bddcc] */
            ii(0x1016_88a1, 6); mov(al, memb[ds, eax + 0x1020_0520]);   /* mov al, [eax+0x10200520] */
            ii(0x1016_88a7, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_88ac, 5); or(eax, 0x1_0000);                      /* or eax, 0x10000 */
            ii(0x1016_88b1, 1); push(eax);                              /* push eax */
            ii(0x1016_88b2, 7); lea(eax, memd[ds, esi * 4]);            /* lea eax, [esi*4] */
            ii(0x1016_88b9, 3); lea(edx, memd[ss, ebp + 8]);            /* lea edx, [ebp+0x8] */
            ii(0x1016_88bc, 2); mov(ecx, esi);                          /* mov ecx, esi */
            ii(0x1016_88be, 2); sub(eax, esi);                          /* sub eax, esi */
            ii(0x1016_88c0, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x1016_88c2, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1016_88c4, 4); mov(edx, memd[ss, esp + 0x58]);         /* mov edx, [esp+0x58] */
            ii(0x1016_88c8, 6); call_abs(memd[ds, 0x101b_ddec]);        /* call dword [0x101bddec] */ /* Вызов '0x1016_a320'. */
            ii(0x1016_88ce, 5); mov(eax, memd[ds, 0x101b_ddc8]);        /* mov eax, [0x101bddc8] */
            ii(0x1016_88d3, 6); mov(al, memb[ds, eax + 0x1020_0520]);   /* mov al, [eax+0x10200520] */
            ii(0x1016_88d9, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_88de, 1); push(eax);                              /* push eax */
            ii(0x1016_88df, 5); mov(eax, memd[ds, 0x101b_ddc4]);        /* mov eax, [0x101bddc4] */
            ii(0x1016_88e4, 6); mov(al, memb[ds, eax + 0x1020_0520]);   /* mov al, [eax+0x10200520] */
            ii(0x1016_88ea, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_88ef, 1); push(eax);                              /* push eax */
            ii(0x1016_88f0, 3); lea(eax, memd[ds, edi - 3]);            /* lea eax, [edi-0x3] */
            ii(0x1016_88f3, 5); mov(ecx, 2);                            /* mov ecx, 0x2 */
            ii(0x1016_88f8, 4); mov(memd[ss, esp + 0x1c], eax);         /* mov [esp+0x1c], eax */
            ii(0x1016_88fc, 1); push(eax);                              /* push eax */
            ii(0x1016_88fd, 3); lea(eax, memd[ds, esi - 3]);            /* lea eax, [esi-0x3] */
            ii(0x1016_8900, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x1016_8902, 4); mov(memd[ss, esp + 0x10], eax);         /* mov [esp+0x10], eax */
            ii(0x1016_8906, 1); push(eax);                              /* push eax */
            ii(0x1016_8907, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1016_8909, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1016_890b, 5); call(/* sys */ 0x1016_a714, 0x1e04);    /* call 0x1016a714 */
            ii(0x1016_8910, 5); mov(eax, memd[ds, 0x101b_ddc8]);        /* mov eax, [0x101bddc8] */
            ii(0x1016_8915, 6); mov(al, memb[ds, eax + 0x1020_0520]);   /* mov al, [eax+0x10200520] */
            ii(0x1016_891b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_8920, 1); push(eax);                              /* push eax */
            ii(0x1016_8921, 5); mov(eax, memd[ds, 0x101b_ddc4]);        /* mov eax, [0x101bddc4] */
            ii(0x1016_8926, 6); mov(al, memb[ds, eax + 0x1020_0520]);   /* mov al, [eax+0x10200520] */
            ii(0x1016_892c, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_8931, 1); push(eax);                              /* push eax */
            ii(0x1016_8932, 3); lea(eax, memd[ds, edi - 2]);            /* lea eax, [edi-0x2] */
            ii(0x1016_8935, 5); mov(ecx, 1);                            /* mov ecx, 0x1 */
            ii(0x1016_893a, 4); mov(memd[ss, esp + 0x24], eax);         /* mov [esp+0x24], eax */
            ii(0x1016_893e, 1); push(eax);                              /* push eax */
            ii(0x1016_893f, 3); lea(eax, memd[ds, esi - 2]);            /* lea eax, [esi-0x2] */
            ii(0x1016_8942, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x1016_8944, 4); mov(memd[ss, esp + 0x24], eax);         /* mov [esp+0x24], eax */
            ii(0x1016_8948, 1); push(eax);                              /* push eax */
            ii(0x1016_8949, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1016_894b, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1016_894d, 5); call(/* sys */ 0x1016_a714, 0x1dc2);    /* call 0x1016a714 */
            ii(0x1016_8952, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_8954, 5); mov(al, memb[ds, 0x1020_0520]);         /* mov al, [0x10200520] */
            ii(0x1016_8959, 1); push(eax);                              /* push eax */
            ii(0x1016_895a, 3); lea(eax, memd[ds, edi - 1]);            /* lea eax, [edi-0x1] */
            ii(0x1016_895d, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_895f, 4); mov(memd[ss, esp + 0xc], eax);          /* mov [esp+0xc], eax */
            ii(0x1016_8963, 1); push(eax);                              /* push eax */
            ii(0x1016_8964, 3); lea(eax, memd[ds, esi - 1]);            /* lea eax, [esi-0x1] */
            ii(0x1016_8967, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_8969, 4); mov(memd[ss, esp + 0x14], eax);         /* mov [esp+0x14], eax */
            ii(0x1016_896d, 1); push(eax);                              /* push eax */
            ii(0x1016_896e, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1016_8970, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1016_8972, 5); call(/* sys */ 0x1016_a68c, 0x1d15);    /* call 0x1016a68c */
            ii(0x1016_8977, 5); mov(eax, memd[ds, 0x101b_ddcc]);        /* mov eax, [0x101bddcc] */
            ii(0x1016_897c, 6); mov(al, memb[ds, eax + 0x1020_0520]);   /* mov al, [eax+0x10200520] */
            ii(0x1016_8982, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_8987, 5); or(eax, 0x1_0000);                      /* or eax, 0x10000 */
            ii(0x1016_898c, 4); mov(edx, memd[ss, esp + 0x34]);         /* mov edx, [esp+0x34] */
            ii(0x1016_8990, 1); push(eax);                              /* push eax */
            ii(0x1016_8991, 7); lea(eax, memd[ds, esi * 4]);            /* lea eax, [esi*4] */
            ii(0x1016_8998, 3); add(edx, 9);                            /* add edx, 0x9 */
            ii(0x1016_899b, 2); mov(ecx, esi);                          /* mov ecx, esi */
            ii(0x1016_899d, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x1016_899f, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1016_89a1, 4); mov(edx, memd[ss, esp + 0x58]);         /* mov edx, [esp+0x58] */
            ii(0x1016_89a5, 6); call_abs(memd[ds, 0x101b_ddec]);        /* call dword [0x101bddec] */ /* Вызов '0x1016_a320'. */
            ii(0x1016_89ab, 5); mov(eax, memd[ds, 0x101b_ddc4]);        /* mov eax, [0x101bddc4] */
            ii(0x1016_89b0, 6); mov(al, memb[ds, eax + 0x1020_0520]);   /* mov al, [eax+0x10200520] */
            ii(0x1016_89b6, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_89bb, 1); push(eax);                              /* push eax */
            ii(0x1016_89bc, 5); mov(eax, memd[ds, 0x101b_ddc8]);        /* mov eax, [0x101bddc8] */
            ii(0x1016_89c1, 6); mov(al, memb[ds, eax + 0x1020_0520]);   /* mov al, [eax+0x10200520] */
            ii(0x1016_89c7, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_89cc, 1); push(eax);                              /* push eax */
            ii(0x1016_89cd, 4); mov(ebx, memd[ss, esp + 0x1c]);         /* mov ebx, [esp+0x1c] */
            ii(0x1016_89d1, 1); push(ebx);                              /* push ebx */
            ii(0x1016_89d2, 4); mov(ecx, memd[ss, esp + 0x10]);         /* mov ecx, [esp+0x10] */
            ii(0x1016_89d6, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1016_89d8, 1); push(ecx);                              /* push ecx */
            ii(0x1016_89d9, 5); mov(ecx, 2);                            /* mov ecx, 0x2 */
            ii(0x1016_89de, 4); mov(eax, memd[ss, esp + 0x44]);         /* mov eax, [esp+0x44] */
            ii(0x1016_89e2, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x1016_89e4, 5); call(/* sys */ 0x1016_a714, 0x1d2b);    /* call 0x1016a714 */
            ii(0x1016_89e9, 5); mov(eax, memd[ds, 0x101b_ddc4]);        /* mov eax, [0x101bddc4] */
            ii(0x1016_89ee, 6); mov(al, memb[ds, eax + 0x1020_0520]);   /* mov al, [eax+0x10200520] */
            ii(0x1016_89f4, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_89f9, 1); push(eax);                              /* push eax */
            ii(0x1016_89fa, 5); mov(eax, memd[ds, 0x101b_ddc8]);        /* mov eax, [0x101bddc8] */
            ii(0x1016_89ff, 6); mov(al, memb[ds, eax + 0x1020_0520]);   /* mov al, [eax+0x10200520] */
            ii(0x1016_8a05, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_8a0a, 1); push(eax);                              /* push eax */
            ii(0x1016_8a0b, 4); mov(eax, memd[ss, esp + 0x24]);         /* mov eax, [esp+0x24] */
            ii(0x1016_8a0f, 5); mov(ecx, 1);                            /* mov ecx, 0x1 */
            ii(0x1016_8a14, 1); push(eax);                              /* push eax */
            ii(0x1016_8a15, 4); mov(edx, memd[ss, esp + 0x24]);         /* mov edx, [esp+0x24] */
            ii(0x1016_8a19, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x1016_8a1b, 1); push(edx);                              /* push edx */
            ii(0x1016_8a1c, 4); mov(eax, memd[ss, esp + 0x44]);         /* mov eax, [esp+0x44] */
            ii(0x1016_8a20, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1016_8a22, 5); call(/* sys */ 0x1016_a714, 0x1ced);    /* call 0x1016a714 */
            ii(0x1016_8a27, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_8a29, 5); mov(al, memb[ds, 0x1020_0520]);         /* mov al, [0x10200520] */
            ii(0x1016_8a2e, 1); push(eax);                              /* push eax */
            ii(0x1016_8a2f, 4); mov(ebx, memd[ss, esp + 0xc]);          /* mov ebx, [esp+0xc] */
            ii(0x1016_8a33, 4); mov(ecx, memd[ss, esp + 0x10]);         /* mov ecx, [esp+0x10] */
            ii(0x1016_8a37, 1); push(ebx);                              /* push ebx */
            ii(0x1016_8a38, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1016_8a3a, 4); mov(eax, memd[ss, esp + 0x3c]);         /* mov eax, [esp+0x3c] */
            ii(0x1016_8a3e, 1); push(ecx);                              /* push ecx */
            ii(0x1016_8a3f, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_8a41, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_8a43, 5); call(/* sys */ 0x1016_a68c, 0x1c44);    /* call 0x1016a68c */
            ii(0x1016_8a48, 2); push(0);                                /* push 0x0 */
            ii(0x1016_8a4a, 4); mov(eax, memd[ss, esp + 0x38]);         /* mov eax, [esp+0x38] */
            ii(0x1016_8a4e, 1); push(eax);                              /* push eax */
            ii(0x1016_8a4f, 1); push(ebp);                              /* push ebp */
            ii(0x1016_8a50, 4); mov(edx, memd[ss, esp + 0x64]);         /* mov edx, [esp+0x64] */
            ii(0x1016_8a54, 1); push(edx);                              /* push edx */
            ii(0x1016_8a55, 4); mov(ebx, memd[ss, esp + 0x60]);         /* mov ebx, [esp+0x60] */
            ii(0x1016_8a59, 1); push(ebx);                              /* push ebx */
            ii(0x1016_8a5a, 4); mov(ecx, memd[ss, esp + 0x60]);         /* mov ecx, [esp+0x60] */
            ii(0x1016_8a5e, 1); push(ecx);                              /* push ecx */
            ii(0x1016_8a5f, 4); mov(eax, memd[ss, esp + 0x60]);         /* mov eax, [esp+0x60] */
            ii(0x1016_8a63, 1); push(eax);                              /* push eax */
            ii(0x1016_8a64, 4); mov(edx, memd[ss, esp + 0x1c]);         /* mov edx, [esp+0x1c] */
            ii(0x1016_8a68, 1); push(edx);                              /* push edx */
            ii(0x1016_8a69, 4); mov(ebx, memd[ss, esp + 0x4c]);         /* mov ebx, [esp+0x4c] */
            ii(0x1016_8a6d, 2); mov(ecx, esi);                          /* mov ecx, esi */
            ii(0x1016_8a6f, 1); push(edi);                              /* push edi */
            ii(0x1016_8a70, 4); mov(eax, memd[ss, esp + 0x34]);         /* mov eax, [esp+0x34] */
            ii(0x1016_8a74, 4); mov(edx, memd[ss, esp + 0x4c]);         /* mov edx, [esp+0x4c] */
            ii(0x1016_8a78, 5); call(/* sys */ 0x1016_8c64, 0x1e7);     /* call 0x10168c64 */
            ii(0x1016_8a7d, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_8a7f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_8a81, 2); if(jnz(0x1016_8aa1, 0x1e)) goto l_0x1016_8aa1; /* jnz 0x10168aa1 */
            ii(0x1016_8a83, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1016_8a85, 5); call(Definitions.sys_free_internal, 0x1_99ca); /* call 0x10182454 */
            ii(0x1016_8a8a, 4); mov(eax, memd[ss, esp + 0x34]);         /* mov eax, [esp+0x34] */
            ii(0x1016_8a8e, 5); call(Definitions.sys_free_internal, 0x1_99c1); /* call 0x10182454 */
            ii(0x1016_8a93, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1016_8a98, 3); add(esp, 0x38);                         /* add esp, 0x38 */
            ii(0x1016_8a9b, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_8a9c, 1); pop(edi);                               /* pop edi */
            ii(0x1016_8a9d, 1); pop(esi);                               /* pop esi */
            ii(0x1016_8a9e, 3); ret(0x14); return;                      /* ret 0x14 */
        l_0x1016_8aa1:
            ii(0x1016_8aa1, 2); push(0);                                /* push 0x0 */
            ii(0x1016_8aa3, 4); mov(edx, memd[ss, esp + 0x28]);         /* mov edx, [esp+0x28] */
            ii(0x1016_8aa7, 3); mov(ebx, memd[ds, eax + 0x30]);         /* mov ebx, [eax+0x30] */
            ii(0x1016_8aaa, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_8aac, 5); call(/* sys */ 0x1016_9b90, 0x10df);    /* call 0x10169b90 */
            ii(0x1016_8ab1, 2); mov(eax, memd[ds, esi]);                /* mov eax, [esi] */
        l_0x1016_8ab3:
            ii(0x1016_8ab3, 3); add(esp, 0x38);                         /* add esp, 0x38 */
            ii(0x1016_8ab6, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_8ab7, 1); pop(edi);                               /* pop edi */
            ii(0x1016_8ab8, 1); pop(esi);                               /* pop esi */
            ii(0x1016_8ab9, 3); ret(0x14);                              /* ret 0x14 */
        }
    }
}
