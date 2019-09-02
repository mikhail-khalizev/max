using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_ba6a-2f69e973")]
        public void Method_1008_ba6a()
        {
            ii(0x1008_ba6a, 5); push(0x58);                             /* push 0x58 */
            ii(0x1008_ba6f, 5); call(Definitions.sys_check_available_stack_size, 0xd_a2de); /* call 0x10165d52 */
            ii(0x1008_ba74, 1); push(ebx);                              /* push ebx */
            ii(0x1008_ba75, 1); push(ecx);                              /* push ecx */
            ii(0x1008_ba76, 1); push(esi);                              /* push esi */
            ii(0x1008_ba77, 1); push(edi);                              /* push edi */
            ii(0x1008_ba78, 1); push(ebp);                              /* push ebp */
            ii(0x1008_ba79, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_ba7b, 6); sub(esp, 0x3c);                         /* sub esp, 0x3c */
            ii(0x1008_ba81, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1008_ba84, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1008_ba87, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_ba8a, 4); mov(ax, memw[ds, eax + 2]);             /* mov ax, [eax+0x2] */
            ii(0x1008_ba8e, 1); inc(eax);                               /* inc eax */
            ii(0x1008_ba8f, 1); cwde();                                 /* cwde */
            ii(0x1008_ba90, 1); push(eax);                              /* push eax */
            ii(0x1008_ba91, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_ba94, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1008_ba97, 1); inc(eax);                               /* inc eax */
            ii(0x1008_ba98, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1008_ba9b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_ba9e, 2); mov(ebx, memd[ds, eax]);                /* mov ebx, [eax] */
            ii(0x1008_baa0, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1008_baa3, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_baa6, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x1008_baa9, 3); lea(eax, memd[ss, ebp - 0x30]);         /* lea eax, [ebp-0x30] */
            ii(0x1008_baac, 5); call(0x1008_b148, -0x969);              /* call 0x1008b148 */
            ii(0x1008_bab1, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1008_bab5, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1008_bab8, 5); mov(edx, 0x101c_81c0);                  /* mov edx, 0x101c81c0 */
            ii(0x1008_babd, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1008_babf, 3); mov(memd[ss, ebp - 0x34], edx);         /* mov [ebp-0x34], edx */
            ii(0x1008_bac2, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x1008_bac6, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x1008_baca, 4); mov(memb[ss, ebp - 0x10], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x1008_bace, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1008_bad1, 3); test(memb[ds, eax], 0x10);              /* test byte [eax], 0x10 */
            ii(0x1008_bad4, 2); if(jz(0x1008_bae2, 0xc)) goto l_0x1008_bae2; /* jz 0x1008bae2 */
            ii(0x1008_bad6, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1008_bad9, 3); inc(memd[ss, ebp - 0x28]);              /* inc dword [ebp-0x28] */
            ii(0x1008_badc, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1008_badf, 3); inc(memd[ss, ebp - 0x24]);              /* inc dword [ebp-0x24] */
        l_0x1008_bae2:
            ii(0x1008_bae2, 4); cmp(memd[ss, ebp - 0x30], 0);           /* cmp dword [ebp-0x30], 0x0 */
            ii(0x1008_bae6, 2); if(jl(0x1008_baee, 6)) goto l_0x1008_baee; /* jl 0x1008baee */
            ii(0x1008_bae8, 4); cmp(memd[ss, ebp - 0x2c], 0);           /* cmp dword [ebp-0x2c], 0x0 */
            ii(0x1008_baec, 2); if(jge(0x1008_baf0, 2)) goto l_0x1008_baf0; /* jge 0x1008baf0 */
        l_0x1008_baee:
            ii(0x1008_baee, 2); jmp(0x1008_bafd, 0xd); goto l_0x1008_bafd; /* jmp 0x1008bafd */
        l_0x1008_baf0:
            ii(0x1008_baf0, 5); mov(eax, memd[ds, 0x101c_8170]);        /* mov eax, [0x101c8170] */
            ii(0x1008_baf5, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_baf8, 3); cmp(eax, memd[ss, ebp - 0x28]);         /* cmp eax, [ebp-0x28] */
            ii(0x1008_bafb, 2); if(jge(0x1008_baff, 2)) goto l_0x1008_baff; /* jge 0x1008baff */
        l_0x1008_bafd:
            ii(0x1008_bafd, 2); jmp(0x1008_bb0c, 0xd); goto l_0x1008_bb0c; /* jmp 0x1008bb0c */
        l_0x1008_baff:
            ii(0x1008_baff, 5); mov(eax, memd[ds, 0x101c_8172]);        /* mov eax, [0x101c8172] */
            ii(0x1008_bb04, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_bb07, 3); cmp(eax, memd[ss, ebp - 0x24]);         /* cmp eax, [ebp-0x24] */
            ii(0x1008_bb0a, 2); if(jge(0x1008_bb15, 9)) goto l_0x1008_bb15; /* jge 0x1008bb15 */
        l_0x1008_bb0c:
            ii(0x1008_bb0c, 4); mov(memb[ss, ebp - 0x18], 0);           /* mov byte [ebp-0x18], 0x0 */
            ii(0x1008_bb10, 5); jmp(0x1008_bbe2, 0xcd); goto l_0x1008_bbe2; /* jmp 0x1008bbe2 */
        l_0x1008_bb15:
            ii(0x1008_bb15, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1008_bb18, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1008_bb1b, 2); jmp(0x1008_bb23, 6); goto l_0x1008_bb23; /* jmp 0x1008bb23 */
        l_0x1008_bb1d:
            ii(0x1008_bb1d, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1008_bb20, 3); inc(memd[ss, ebp - 0x20]);              /* inc dword [ebp-0x20] */
        l_0x1008_bb23:
            ii(0x1008_bb23, 4); movsx(eax, memw[ss, ebp - 0x20]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1008_bb27, 3); cmp(eax, memd[ss, ebp - 0x28]);         /* cmp eax, [ebp-0x28] */
            ii(0x1008_bb2a, 6); if(jge(0x1008_bba1, 0x71)) goto l_0x1008_bba1; /* jge 0x1008bba1 */
            ii(0x1008_bb30, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x1008_bb33, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1008_bb36, 2); jmp(0x1008_bb3e, 6); goto l_0x1008_bb3e; /* jmp 0x1008bb3e */
        l_0x1008_bb38:
            ii(0x1008_bb38, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1008_bb3b, 3); inc(memd[ss, ebp - 0x1c]);              /* inc dword [ebp-0x1c] */
        l_0x1008_bb3e:
            ii(0x1008_bb3e, 4); movsx(eax, memw[ss, ebp - 0x1c]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1008_bb42, 3); cmp(eax, memd[ss, ebp - 0x24]);         /* cmp eax, [ebp-0x24] */
            ii(0x1008_bb45, 2); if(jge(0x1008_bb9c, 0x55)) goto l_0x1008_bb9c; /* jge 0x1008bb9c */
            ii(0x1008_bb47, 4); movsx(edx, memw[ss, ebp - 0x1c]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x1008_bb4b, 4); movsx(eax, memw[ss, ebp - 0x20]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1008_bb4f, 5); call(0x1007_3d48, -0x1_7e0c);           /* call 0x10073d48 */
            ii(0x1008_bb54, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x1008_bb57, 2); jmp(0x1008_bb74, 0x1b); goto l_0x1008_bb74; /* jmp 0x1008bb74 */
        l_0x1008_bb59:
            ii(0x1008_bb59, 4); mov(memb[ss, ebp - 0x14], 1);           /* mov byte [ebp-0x14], 0x1 */
            ii(0x1008_bb5d, 2); jmp(0x1008_bb9a, 0x3b); goto l_0x1008_bb9a; /* jmp 0x1008bb9a */
        l_0x1008_bb5f:
            ii(0x1008_bb5f, 4); mov(memb[ss, ebp - 0xc], 1);            /* mov byte [ebp-0xc], 0x1 */
            ii(0x1008_bb63, 2); jmp(0x1008_bb9a, 0x35); goto l_0x1008_bb9a; /* jmp 0x1008bb9a */
        l_0x1008_bb65:
            ii(0x1008_bb65, 4); mov(memb[ss, ebp - 0x10], 1);           /* mov byte [ebp-0x10], 0x1 */
            ii(0x1008_bb69, 2); jmp(0x1008_bb9a, 0x2f); goto l_0x1008_bb9a; /* jmp 0x1008bb9a */
        l_0x1008_bb6b:
            ii(0x1008_bb6b, 4); mov(memb[ss, ebp - 0x18], 0);           /* mov byte [ebp-0x18], 0x0 */
            ii(0x1008_bb6f, 5); jmp(0x1008_bbe2, 0x6e); goto l_0x1008_bbe2; /* jmp 0x1008bbe2 */
        l_0x1008_bb74:
            ii(0x1008_bb74, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x1008_bb77, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
            ii(0x1008_bb7a, 5); cmp(memw[ss, ebp - 0x3c], 2);           /* cmp word [ebp-0x3c], 0x2 */
            ii(0x1008_bb7f, 2); if(jb(0x1008_bb91, 0x10)) goto l_0x1008_bb91; /* jb 0x1008bb91 */
            ii(0x1008_bb81, 5); cmp(memw[ss, ebp - 0x3c], 2);           /* cmp word [ebp-0x3c], 0x2 */
            ii(0x1008_bb86, 2); if(jbe(0x1008_bb5f, -0x29)) goto l_0x1008_bb5f; /* jbe 0x1008bb5f */
            ii(0x1008_bb88, 5); cmp(memw[ss, ebp - 0x3c], 4);           /* cmp word [ebp-0x3c], 0x4 */
            ii(0x1008_bb8d, 2); if(jz(0x1008_bb65, -0x2a)) goto l_0x1008_bb65; /* jz 0x1008bb65 */
            ii(0x1008_bb8f, 2); jmp(0x1008_bb6b, -0x26); goto l_0x1008_bb6b; /* jmp 0x1008bb6b */
        l_0x1008_bb91:
            ii(0x1008_bb91, 5); cmp(memw[ss, ebp - 0x3c], 1);           /* cmp word [ebp-0x3c], 0x1 */
            ii(0x1008_bb96, 2); if(jz(0x1008_bb59, -0x3f)) goto l_0x1008_bb59; /* jz 0x1008bb59 */
            ii(0x1008_bb98, 2); jmp(0x1008_bb6b, -0x2f); goto l_0x1008_bb6b; /* jmp 0x1008bb6b */
        l_0x1008_bb9a:
            ii(0x1008_bb9a, 2); jmp(0x1008_bb38, -0x64); goto l_0x1008_bb38; /* jmp 0x1008bb38 */
        l_0x1008_bb9c:
            ii(0x1008_bb9c, 5); jmp(0x1008_bb1d, -0x84); goto l_0x1008_bb1d; /* jmp 0x1008bb1d */
        l_0x1008_bba1:
            ii(0x1008_bba1, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1008_bba4, 4); test(memb[ds, eax + 0x14], 1);          /* test byte [eax+0x14], 0x1 */
            ii(0x1008_bba8, 2); if(jnz(0x1008_bbb0, 6)) goto l_0x1008_bbb0; /* jnz 0x1008bbb0 */
            ii(0x1008_bbaa, 4); cmp(memb[ss, ebp - 0x14], 0);           /* cmp byte [ebp-0x14], 0x0 */
            ii(0x1008_bbae, 2); if(jnz(0x1008_bbb2, 2)) goto l_0x1008_bbb2; /* jnz 0x1008bbb2 */
        l_0x1008_bbb0:
            ii(0x1008_bbb0, 2); jmp(0x1008_bbb8, 6); goto l_0x1008_bbb8; /* jmp 0x1008bbb8 */
        l_0x1008_bbb2:
            ii(0x1008_bbb2, 4); mov(memb[ss, ebp - 0x18], 0);           /* mov byte [ebp-0x18], 0x0 */
            ii(0x1008_bbb6, 2); jmp(0x1008_bbe2, 0x2a); goto l_0x1008_bbe2; /* jmp 0x1008bbe2 */
        l_0x1008_bbb8:
            ii(0x1008_bbb8, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1008_bbbb, 4); test(memb[ds, eax + 0x14], 2);          /* test byte [eax+0x14], 0x2 */
            ii(0x1008_bbbf, 2); if(jnz(0x1008_bbc7, 6)) goto l_0x1008_bbc7; /* jnz 0x1008bbc7 */
            ii(0x1008_bbc1, 4); cmp(memb[ss, ebp - 0xc], 0);            /* cmp byte [ebp-0xc], 0x0 */
            ii(0x1008_bbc5, 2); if(jnz(0x1008_bbd8, 0x11)) goto l_0x1008_bbd8; /* jnz 0x1008bbd8 */
        l_0x1008_bbc7:
            ii(0x1008_bbc7, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1008_bbca, 4); test(memb[ds, eax + 0x14], 4);          /* test byte [eax+0x14], 0x4 */
            ii(0x1008_bbce, 2); if(jnz(0x1008_bbd6, 6)) goto l_0x1008_bbd6; /* jnz 0x1008bbd6 */
            ii(0x1008_bbd0, 4); cmp(memb[ss, ebp - 0x10], 0);           /* cmp byte [ebp-0x10], 0x0 */
            ii(0x1008_bbd4, 2); if(jnz(0x1008_bbd8, 2)) goto l_0x1008_bbd8; /* jnz 0x1008bbd8 */
        l_0x1008_bbd6:
            ii(0x1008_bbd6, 2); jmp(0x1008_bbde, 6); goto l_0x1008_bbde; /* jmp 0x1008bbde */
        l_0x1008_bbd8:
            ii(0x1008_bbd8, 4); mov(memb[ss, ebp - 0x18], 2);           /* mov byte [ebp-0x18], 0x2 */
            ii(0x1008_bbdc, 2); jmp(0x1008_bbe2, 4); goto l_0x1008_bbe2; /* jmp 0x1008bbe2 */
        l_0x1008_bbde:
            ii(0x1008_bbde, 4); mov(memb[ss, ebp - 0x18], 1);           /* mov byte [ebp-0x18], 0x1 */
        l_0x1008_bbe2:
            ii(0x1008_bbe2, 3); mov(al, memb[ss, ebp - 0x18]);          /* mov al, [ebp-0x18] */
            ii(0x1008_bbe5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_bbe7, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_bbe8, 1); pop(edi);                               /* pop edi */
            ii(0x1008_bbe9, 1); pop(esi);                               /* pop esi */
            ii(0x1008_bbea, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_bbeb, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_bbec, 1); ret();                                  /* ret */
        }
    }
}
