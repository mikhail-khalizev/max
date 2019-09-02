using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_da28-ccfffdb9")]
        public void Method_100f_da28()
        {
            ii(0x100f_da28, 5); push(0x3c);                             /* push 0x3c */
            ii(0x100f_da2d, 5); call(Definitions.sys_check_available_stack_size, 0x6_8320); /* call 0x10165d52 */
            ii(0x100f_da32, 1); push(ebx);                              /* push ebx */
            ii(0x100f_da33, 1); push(ecx);                              /* push ecx */
            ii(0x100f_da34, 1); push(esi);                              /* push esi */
            ii(0x100f_da35, 1); push(edi);                              /* push edi */
            ii(0x100f_da36, 1); push(ebp);                              /* push ebp */
            ii(0x100f_da37, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_da39, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x100f_da3f, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100f_da42, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100f_da45, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100f_da49, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_da4b, 6); if(jle(0x100f_dbf5, 0x1a4)) goto l_0x100f_dbf5; /* jle 0x100fdbf5 */
            ii(0x100f_da51, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100f_da54, 5); call(Definitions.my_ctor_0x101b_4184, -0x8_6f69); /* call 0x10076af0 */
            ii(0x100f_da59, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x100f_da5c, 5); call(Definitions.my_ctor_0x101b_4184, -0x8_6f71); /* call 0x10076af0 */
            ii(0x100f_da61, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x100f_da65, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x100f_da69, 3); shl(edx, 2);                            /* shl edx, 0x2 */
            ii(0x100f_da6c, 5); mov(ebx, 5);                            /* mov ebx, 0x5 */
            ii(0x100f_da71, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_da73, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_da76, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100f_da78, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_da7a, 5); call(/* sys */ 0x1016_5e9b, 0x6_841c);  /* call 0x10165e9b */
            ii(0x100f_da7f, 1); inc(edx);                               /* inc edx */
            ii(0x100f_da80, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100f_da83, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100f_da86, 4); mov(memw[ss, ebp - 0x18], ax);          /* mov [ebp-0x18], ax */
            ii(0x100f_da8a, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x100f_da8e, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_da90, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_da93, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100f_da95, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x100f_da97, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_da99, 5); call(/* sys */ 0x1016_5e9b, 0x6_83fd);  /* call 0x10165e9b */
            ii(0x100f_da9e, 1); inc(edx);                               /* inc edx */
            ii(0x100f_da9f, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100f_daa2, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100f_daa5, 4); mov(memw[ss, ebp - 0x16], ax);          /* mov [ebp-0x16], ax */
            ii(0x100f_daa9, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100f_daac, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100f_daaf, 2); jmp(0x100f_dacd, 0x1c); goto l_0x100f_dacd; /* jmp 0x100fdacd */
        l_0x100f_dab1:
            ii(0x100f_dab1, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x100f_dab5, 3); shl(edx, 2);                            /* shl edx, 0x2 */
            ii(0x100f_dab8, 5); mov(ebx, 5);                            /* mov ebx, 0x5 */
            ii(0x100f_dabd, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_dabf, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_dac2, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100f_dac4, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100f_dac8, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100f_daca, 3); mov(memd[ss, ebp - 0x10], edx);         /* mov [ebp-0x10], edx */
        l_0x100f_dacd:
            ii(0x100f_dacd, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_dad0, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x100f_dad7, 6); if(jge(0x100f_dbf5, 0x118)) goto l_0x100f_dbf5; /* jge 0x100fdbf5 */
            ii(0x100f_dadd, 3); mov(eax, memd[ss, ebp - 0x16]);         /* mov eax, [ebp-0x16] */
            ii(0x100f_dae0, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100f_dae3, 4); cmp(memb[ss, ebp - 0xc], 0);            /* cmp byte [ebp-0xc], 0x0 */
            ii(0x100f_dae7, 2); if(jz(0x100f_daff, 0x16)) goto l_0x100f_daff; /* jz 0x100fdaff */
            ii(0x100f_dae9, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x100f_daed, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_daef, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_daf2, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100f_daf4, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x100f_daf6, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x100f_dafa, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100f_dafc, 3); mov(memd[ss, ebp - 0x14], edx);         /* mov [ebp-0x14], edx */
        l_0x100f_daff:
            ii(0x100f_daff, 2); jmp(0x100f_db07, 6); goto l_0x100f_db07; /* jmp 0x100fdb07 */
        l_0x100f_db01:
            ii(0x100f_db01, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100f_db04, 3); add(memd[ss, ebp - 0x14], eax);         /* add [ebp-0x14], eax */
        l_0x100f_db07:
            ii(0x100f_db07, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100f_db0a, 7); cmp(ax, memw[ds, 0x101c_8174]);         /* cmp ax, [0x101c8174] */
            ii(0x100f_db11, 6); if(jge(0x100f_dbda, 0xc3)) goto l_0x100f_dbda; /* jge 0x100fdbda */
            ii(0x100f_db17, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x100f_db1b, 2); neg(edx);                               /* neg edx */
            ii(0x100f_db1d, 5); mov(ebx, 5);                            /* mov ebx, 0x5 */
            ii(0x100f_db22, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_db24, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_db27, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100f_db29, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100f_db2b, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x100f_db2f, 5); mov(ecx, 5);                            /* mov ecx, 0x5 */
            ii(0x100f_db34, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_db36, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_db39, 2); idiv(ecx);                              /* idiv ecx */
            ii(0x100f_db3b, 2); sub(eax, ebx);                          /* sub eax, ebx */
            ii(0x100f_db3d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_db3f, 5); call(/* sys */ 0x1016_5e9b, 0x6_8357);  /* call 0x10165e9b */
            ii(0x100f_db44, 1); inc(edx);                               /* inc edx */
            ii(0x100f_db45, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100f_db48, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100f_db4b, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100f_db4d, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x100f_db51, 2); neg(edx);                               /* neg edx */
            ii(0x100f_db53, 5); mov(ecx, 5);                            /* mov ecx, 0x5 */
            ii(0x100f_db58, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_db5a, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_db5d, 2); idiv(ecx);                              /* idiv ecx */
            ii(0x100f_db5f, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100f_db61, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100f_db65, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100f_db67, 4); mov(memw[ss, ebp - 0x1c], ax);          /* mov [ebp-0x1c], ax */
            ii(0x100f_db6b, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x100f_db6f, 2); neg(edx);                               /* neg edx */
            ii(0x100f_db71, 5); mov(ebx, 5);                            /* mov ebx, 0x5 */
            ii(0x100f_db76, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_db78, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_db7b, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100f_db7d, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100f_db7f, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x100f_db83, 5); mov(ecx, 5);                            /* mov ecx, 0x5 */
            ii(0x100f_db88, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_db8a, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_db8d, 2); idiv(ecx);                              /* idiv ecx */
            ii(0x100f_db8f, 2); sub(eax, ebx);                          /* sub eax, ebx */
            ii(0x100f_db91, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_db93, 5); call(/* sys */ 0x1016_5e9b, 0x6_8303);  /* call 0x10165e9b */
            ii(0x100f_db98, 1); inc(edx);                               /* inc edx */
            ii(0x100f_db99, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100f_db9c, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100f_db9f, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100f_dba1, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x100f_dba5, 2); neg(edx);                               /* neg edx */
            ii(0x100f_dba7, 5); mov(ecx, 5);                            /* mov ecx, 0x5 */
            ii(0x100f_dbac, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_dbae, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_dbb1, 2); idiv(ecx);                              /* idiv ecx */
            ii(0x100f_dbb3, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100f_dbb5, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x100f_dbb9, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100f_dbbb, 4); mov(memw[ss, ebp - 0x1a], ax);          /* mov [ebp-0x1a], ax */
            ii(0x100f_dbbf, 4); movsx(ebx, memw[ss, ebp - 4]);          /* movsx ebx, word [ebp-0x4] */
            ii(0x100f_dbc3, 3); lea(edx, memd[ss, ebp - 0x1c]);         /* lea edx, [ebp-0x1c] */
            ii(0x100f_dbc6, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100f_dbc9, 5); call(0x1007_5e64, -0x8_7d6a);           /* call 0x10075e64 */
            ii(0x100f_dbce, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100f_dbd0, 5); call(0x100f_d3a7, -0x82e);              /* call 0x100fd3a7 */
            ii(0x100f_dbd5, 5); jmp(0x100f_db01, -0xd9); goto l_0x100f_db01; /* jmp 0x100fdb01 */
        l_0x100f_dbda:
            ii(0x100f_dbda, 4); cmp(memb[ss, ebp - 0xc], 0);            /* cmp byte [ebp-0xc], 0x0 */
            ii(0x100f_dbde, 2); if(jnz(0x100f_dbe6, 6)) goto l_0x100f_dbe6; /* jnz 0x100fdbe6 */
            ii(0x100f_dbe0, 4); mov(memb[ss, ebp - 0x24], 1);           /* mov byte [ebp-0x24], 0x1 */
            ii(0x100f_dbe4, 2); jmp(0x100f_dbea, 4); goto l_0x100f_dbea; /* jmp 0x100fdbea */
        l_0x100f_dbe6:
            ii(0x100f_dbe6, 4); mov(memb[ss, ebp - 0x24], 0);           /* mov byte [ebp-0x24], 0x0 */
        l_0x100f_dbea:
            ii(0x100f_dbea, 3); mov(al, memb[ss, ebp - 0x24]);          /* mov al, [ebp-0x24] */
            ii(0x100f_dbed, 3); mov(memb[ss, ebp - 0xc], al);           /* mov [ebp-0xc], al */
            ii(0x100f_dbf0, 5); jmp(0x100f_dab1, -0x144); goto l_0x100f_dab1; /* jmp 0x100fdab1 */
        l_0x100f_dbf5:
            ii(0x100f_dbf5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_dbf7, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_dbf8, 1); pop(edi);                               /* pop edi */
            ii(0x100f_dbf9, 1); pop(esi);                               /* pop esi */
            ii(0x100f_dbfa, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_dbfb, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_dbfc, 1); ret();                                  /* ret */
        }
    }
}
