using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_d9b1-e7f88aa6")]
        public void Method_1015_d9b1()
        {
            ii(0x1015_d9b1, 5); push(0x34);                             /* push 0x34 */
            ii(0x1015_d9b6, 5); call(Definitions.sys_check_available_stack_size, 0x8397); /* call 0x10165d52 */
            ii(0x1015_d9bb, 1); push(ecx);                              /* push ecx */
            ii(0x1015_d9bc, 1); push(esi);                              /* push esi */
            ii(0x1015_d9bd, 1); push(edi);                              /* push edi */
            ii(0x1015_d9be, 1); push(ebp);                              /* push ebp */
            ii(0x1015_d9bf, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_d9c1, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1015_d9c7, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1015_d9ca, 3); mov(memd[ss, ebp - 0x8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1015_d9cd, 3); mov(memd[ss, ebp - 0x4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1015_d9d0, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_d9d3, 5); cmp(memw[ds, eax + 0x8], 0x31);         /* cmp word [eax+0x8], 0x31 */
            ii(0x1015_d9d8, 2); if(jnz(0x1015_d9e3, 0x9)) goto l_0x1015_d9e3; /* jnz 0x1015d9e3 */
            ii(0x1015_d9da, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_d9dd, 4); cmp(memb[ds, eax + 0x3d], 0x4);         /* cmp byte [eax+0x3d], 0x4 */
            ii(0x1015_d9e1, 2); if(jz(0x1015_d9e5, 0x2)) goto l_0x1015_d9e5; /* jz 0x1015d9e5 */
        l_0x1015_d9e3:
            ii(0x1015_d9e3, 2); jmp(0x1015_da14, 0x2f); goto l_0x1015_da14; /* jmp 0x1015da14 */
        l_0x1015_d9e5:
            ii(0x1015_d9e5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_d9e8, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x1015_d9eb, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1015_d9ee, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_d9f1, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x1015_d9f4, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_d9f7, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_d9fa, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1015_d9fd, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1015_d9ff, 1); cwde();                                 /* cwde */
            ii(0x1015_da00, 5); call(0x1007_3f48, -0xe_9abd);           /* call 0x10073f48 */
            ii(0x1015_da05, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1015_da08, 4); cmp(memd[ss, ebp - 0x14], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1015_da0c, 2); if(jz(0x1015_da14, 0x6)) goto l_0x1015_da14; /* jz 0x1015da14 */
            ii(0x1015_da0e, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1015_da11, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
        l_0x1015_da14:
            ii(0x1015_da14, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_da17, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x1015_da1a, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1015_da1d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_da20, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x1015_da23, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_da26, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_da29, 5); call(0x1007_6aac, -0xe_6f82);           /* call 0x10076aac */
            ii(0x1015_da2e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_da31, 4); test(memb[ds, eax + 0x12], 0x10);       /* test byte [eax+0x12], 0x10 */
            ii(0x1015_da35, 6); if(jz(0x1015_daf9, 0xbe)) goto l_0x1015_daf9; /* jz 0x1015daf9 */
            ii(0x1015_da3b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_da3e, 4); mov(ax, memw[ds, eax + 0x1a]);          /* mov ax, [eax+0x1a] */
            ii(0x1015_da42, 4); cmp(ax, memw[ss, ebp - 0x10]);          /* cmp ax, [ebp-0x10] */
            ii(0x1015_da46, 2); if(jle(0x1015_da4f, 0x7)) goto l_0x1015_da4f; /* jle 0x1015da4f */
            ii(0x1015_da48, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1015_da4b, 4); inc(memw[ss, ebp - 0x10]);              /* inc word [ebp-0x10] */
        l_0x1015_da4f:
            ii(0x1015_da4f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_da52, 4); mov(ax, memw[ds, eax + 0x1c]);          /* mov ax, [eax+0x1c] */
            ii(0x1015_da56, 4); cmp(ax, memw[ss, ebp - 0xe]);           /* cmp ax, [ebp-0xe] */
            ii(0x1015_da5a, 2); if(jle(0x1015_da63, 0x7)) goto l_0x1015_da63; /* jle 0x1015da63 */
            ii(0x1015_da5c, 3); mov(eax, memd[ss, ebp - 0xe]);          /* mov eax, [ebp-0xe] */
            ii(0x1015_da5f, 4); inc(memw[ss, ebp - 0xe]);               /* inc word [ebp-0xe] */
        l_0x1015_da63:
            ii(0x1015_da63, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_da66, 5); cmp(memw[ds, eax + 0x8], 0x47);         /* cmp word [eax+0x8], 0x47 */
            ii(0x1015_da6b, 2); if(jz(0x1015_da7b, 0xe)) goto l_0x1015_da7b; /* jz 0x1015da7b */
            ii(0x1015_da6d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_da70, 5); cmp(memw[ds, eax + 0x8], 0x45);         /* cmp word [eax+0x8], 0x45 */
            ii(0x1015_da75, 6); if(jnz(0x1015_daf9, 0x7e)) goto l_0x1015_daf9; /* jnz 0x1015daf9 */
        l_0x1015_da7b:
            ii(0x1015_da7b, 7); mov(memd[ss, ebp - 0x18], 0x4);         /* mov dword [ebp-0x18], 0x4 */
        l_0x1015_da82:
            ii(0x1015_da82, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1015_da86, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_da88, 6); if(jl(0x1015_daf9, 0x6b)) goto l_0x1015_daf9; /* jl 0x1015daf9 */
            ii(0x1015_da8e, 4); movsx(edx, memw[ss, ebp - 0xe]);        /* movsx edx, word [ebp-0xe] */
            ii(0x1015_da92, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1015_da96, 5); call(0x1007_3cfd, -0xe_9d9e);           /* call 0x10073cfd */
            ii(0x1015_da9b, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1015_da9e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_daa0, 4); mov(ax, memw[ss, ebp - 0x1c]);          /* mov ax, [ebp-0x1c] */
            ii(0x1015_daa4, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1015_daa7, 2); if(jz(0x1015_dab4, 0xb)) goto l_0x1015_dab4; /* jz 0x1015dab4 */
            ii(0x1015_daa9, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_daab, 4); mov(ax, memw[ss, ebp - 0x1c]);          /* mov ax, [ebp-0x1c] */
            ii(0x1015_daaf, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1015_dab2, 2); if(jnz(0x1015_dab6, 0x2)) goto l_0x1015_dab6; /* jnz 0x1015dab6 */
        l_0x1015_dab4:
            ii(0x1015_dab4, 2); jmp(0x1015_daf9, 0x43); goto l_0x1015_daf9; /* jmp 0x1015daf9 */
        l_0x1015_dab6:
            ii(0x1015_dab6, 3); mov(edx, memd[ss, ebp - 0x18]);         /* mov edx, [ebp-0x18] */
            ii(0x1015_dab9, 3); and(edx, 0x1);                          /* and edx, 0x1 */
            ii(0x1015_dabc, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_dabf, 4); mov(ax, memw[ds, eax + 0x1a]);          /* mov ax, [eax+0x1a] */
            ii(0x1015_dac3, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1015_dac5, 4); mov(memw[ss, ebp - 0x10], ax);          /* mov [ebp-0x10], ax */
            ii(0x1015_dac9, 6); test(memw[ss, ebp - 0x18], 0x2);        /* test word [ebp-0x18], 0x2 */
            ii(0x1015_dacf, 2); if(jz(0x1015_dada, 0x9)) goto l_0x1015_dada; /* jz 0x1015dada */
            ii(0x1015_dad1, 7); mov(memd[ss, ebp - 0x20], 0x1);         /* mov dword [ebp-0x20], 0x1 */
            ii(0x1015_dad8, 2); jmp(0x1015_dae1, 0x7); goto l_0x1015_dae1; /* jmp 0x1015dae1 */
        l_0x1015_dada:
            ii(0x1015_dada, 7); mov(memd[ss, ebp - 0x20], 0);           /* mov dword [ebp-0x20], 0x0 */
        l_0x1015_dae1:
            ii(0x1015_dae1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_dae4, 3); mov(eax, memd[ds, eax + 0x1a]);         /* mov eax, [eax+0x1a] */
            ii(0x1015_dae7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_daea, 3); add(eax, memd[ss, ebp - 0x20]);         /* add eax, [ebp-0x20] */
            ii(0x1015_daed, 4); mov(memw[ss, ebp - 0xe], ax);           /* mov [ebp-0xe], ax */
            ii(0x1015_daf1, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1015_daf4, 3); dec(memd[ss, ebp - 0x18]);              /* dec dword [ebp-0x18] */
            ii(0x1015_daf7, 2); jmp(0x1015_da82, -0x77); goto l_0x1015_da82; /* jmp 0x1015da82 */
        l_0x1015_daf9:
            ii(0x1015_daf9, 3); lea(edx, ebp - 0x10);                   /* lea edx, [ebp-0x10] */
            ii(0x1015_dafc, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_daff, 5); call(0x1007_5e64, -0xe_7ca0);           /* call 0x10075e64 */
            ii(0x1015_db04, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_db07, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_db09, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_db0a, 1); pop(edi);                               /* pop edi */
            ii(0x1015_db0b, 1); pop(esi);                               /* pop esi */
            ii(0x1015_db0c, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_db0d, 1); ret();                                  /* ret */
        }
    }
}
