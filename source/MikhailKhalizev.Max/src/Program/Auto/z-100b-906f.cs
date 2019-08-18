using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9e5b89d0-a04f-4d2f-ad2c-35fc9e46d2fe")]
        public void Method_100b_906f()
        {
            ii(0x100b_906f, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x100b_9074, 5); calld(Definitions.sys_check_available_stack_size, 0xa_ccd9); /* call 0x10165d52 */
            ii(0x100b_9079, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_907a, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_907b, 1); pushd(edx);                             /* push edx */
            ii(0x100b_907c, 1); pushd(esi);                             /* push esi */
            ii(0x100b_907d, 1); pushd(edi);                             /* push edi */
            ii(0x100b_907e, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_907f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_9081, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100b_9087, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_908a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_908d, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100b_9090, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_9093, 5); calld(0x100b_8ffa, -0x9e);              /* call 0x100b8ffa */
            ii(0x100b_9098, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x100b_909b, 4); cmp(memb_a32[ss, ebp - 0x8], 0x4);      /* cmp byte [ebp-0x8], 0x4 */
            ii(0x100b_909f, 2); if(jged(0x100b_90ac, 0xb)) goto l_0x100b_90ac; /* jge 0x100b90ac */
            ii(0x100b_90a1, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100b_90a4, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x100b_90a7, 5); jmpd(0x100b_911d, 0x71); goto l_0x100b_911d; /* jmp 0x100b911d */
        l_0x100b_90ac:
            ii(0x100b_90ac, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x100b_90b3, 2); jmpd(0x100b_90bb, 0x6); goto l_0x100b_90bb; /* jmp 0x100b90bb */
        l_0x100b_90b5:
            ii(0x100b_90b5, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_90b8, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
        l_0x100b_90bb:
            ii(0x100b_90bb, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100b_90bf, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100b_90c2, 2); if(jged(0x100b_90ed, 0x29)) goto l_0x100b_90ed; /* jge 0x100b90ed */
            ii(0x100b_90c4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_90c7, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x100b_90ca, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_90cf, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x100b_90d3, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_90d5, 2); if(jzd(0x100b_90e7, 0x10)) goto l_0x100b_90e7; /* jz 0x100b90e7 */
            ii(0x100b_90d7, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x100b_90db, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_90de, 5); calld(0x1007_6274, -0x4_2e6f);          /* call 0x10076274 */
            ii(0x100b_90e3, 2); test(al, al);                           /* test al, al */
            ii(0x100b_90e5, 2); if(jnzd(0x100b_90e9, 0x2)) goto l_0x100b_90e9; /* jnz 0x100b90e9 */
        l_0x100b_90e7:
            ii(0x100b_90e7, 2); jmpd(0x100b_90eb, 0x2); goto l_0x100b_90eb; /* jmp 0x100b90eb */
        l_0x100b_90e9:
            ii(0x100b_90e9, 2); jmpd(0x100b_90ed, 0x2); goto l_0x100b_90ed; /* jmp 0x100b90ed */
        l_0x100b_90eb:
            ii(0x100b_90eb, 2); jmpd(0x100b_90b5, -0x38); goto l_0x100b_90b5; /* jmp 0x100b90b5 */
        l_0x100b_90ed:
            ii(0x100b_90ed, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100b_90f1, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100b_90f4, 2); if(jged(0x100b_90fc, 0x6)) goto l_0x100b_90fc; /* jge 0x100b90fc */
            ii(0x100b_90f6, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100b_90fa, 2); jmpd(0x100b_911d, 0x21); goto l_0x100b_911d; /* jmp 0x100b911d */
        l_0x100b_90fc:
            ii(0x100b_90fc, 4); cmp(memb_a32[ss, ebp - 0x8], 0x5);      /* cmp byte [ebp-0x8], 0x5 */
            ii(0x100b_9100, 2); if(jnzd(0x100b_9111, 0xf)) goto l_0x100b_9111; /* jnz 0x100b9111 */
            ii(0x100b_9102, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_9105, 3); mov(al, memb_a32[ds, eax + 0x50]);      /* mov al, [eax+0x50] */
            ii(0x100b_9108, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_910d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_910f, 2); if(jzd(0x100b_9113, 0x2)) goto l_0x100b_9113; /* jz 0x100b9113 */
        l_0x100b_9111:
            ii(0x100b_9111, 2); jmpd(0x100b_9117, 0x4); goto l_0x100b_9117; /* jmp 0x100b9117 */
        l_0x100b_9113:
            ii(0x100b_9113, 4); mov(memb_a32[ss, ebp - 0x8], 0x4);      /* mov byte [ebp-0x8], 0x4 */
        l_0x100b_9117:
            ii(0x100b_9117, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100b_911a, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
        l_0x100b_911d:
            ii(0x100b_911d, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100b_9120, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_9122, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_9123, 1); popd(edi);                              /* pop edi */
            ii(0x100b_9124, 1); popd(esi);                              /* pop esi */
            ii(0x100b_9125, 1); popd(edx);                              /* pop edx */
            ii(0x100b_9126, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_9127, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_9128, 1); retd(); return;                         /* ret */
        }
    }
}
