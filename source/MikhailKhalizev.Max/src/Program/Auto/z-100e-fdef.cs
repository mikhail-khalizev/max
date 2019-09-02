using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_fdef-46926e6a")]
        public void Method_100e_fdef()
        {
            ii(0x100e_fdef, 5); push(0x38);                             /* push 0x38 */
            ii(0x100e_fdf4, 5); call(Definitions.sys_check_available_stack_size, 0x7_5f59); /* call 0x10165d52 */
            ii(0x100e_fdf9, 1); push(ebx);                              /* push ebx */
            ii(0x100e_fdfa, 1); push(ecx);                              /* push ecx */
            ii(0x100e_fdfb, 1); push(esi);                              /* push esi */
            ii(0x100e_fdfc, 1); push(edi);                              /* push edi */
            ii(0x100e_fdfd, 1); push(ebp);                              /* push ebp */
            ii(0x100e_fdfe, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_fe00, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x100e_fe06, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_fe09, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100e_fe0c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_fe0f, 3); mov(eax, memd[ds, eax + 99]);           /* mov eax, [eax+0x63] */
            ii(0x100e_fe12, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_fe15, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x100e_fe18, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_fe1b, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x100e_fe1e, 7); mov(memd[ss, ebp - 24], 0);             /* mov dword [ebp-0x18], 0x0 */
        l_0x100e_fe25:
            ii(0x100e_fe25, 3); dec(memd[ss, ebp - 28]);                /* dec dword [ebp-0x1c] */
            ii(0x100e_fe28, 4); cmp(memd[ss, ebp - 28], -1 /* 0xff */); /* cmp dword [ebp-0x1c], 0xffffffff */
            ii(0x100e_fe2c, 6); if(jz(0x100e_fec8, 0x96)) goto l_0x100e_fec8; /* jz 0x100efec8 */
            ii(0x100e_fe32, 7); mov(memd[ss, ebp - 32], 0);             /* mov dword [ebp-0x20], 0x0 */
            ii(0x100e_fe39, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100e_fe3c, 3); inc(memd[ss, ebp - 20]);                /* inc dword [ebp-0x14] */
            ii(0x100e_fe3f, 4); mov(memb[ss, ebp - 12], 0);             /* mov byte [ebp-0xc], 0x0 */
            ii(0x100e_fe43, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x100e_fe46, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
        l_0x100e_fe49:
            ii(0x100e_fe49, 4); movsx(eax, memb[ss, ebp - 12]);         /* movsx eax, byte [ebp-0xc] */
            ii(0x100e_fe4d, 3); add(memd[ss, ebp - 32], eax);           /* add [ebp-0x20], eax */
            ii(0x100e_fe50, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_fe53, 3); mov(eax, memd[ds, eax + 97]);           /* mov eax, [eax+0x61] */
            ii(0x100e_fe56, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_fe59, 3); cmp(eax, memd[ss, ebp - 32]);           /* cmp eax, [ebp-0x20] */
            ii(0x100e_fe5c, 2); if(jle(0x100e_feb7, 0x59)) goto l_0x100e_feb7; /* jle 0x100efeb7 */
            ii(0x100e_fe5e, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100e_fe61, 3); inc(memd[ss, ebp - 20]);                /* inc dword [ebp-0x14] */
            ii(0x100e_fe64, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x100e_fe66, 3); mov(memb[ss, ebp - 12], al);            /* mov [ebp-0xc], al */
            ii(0x100e_fe69, 4); movsx(eax, memb[ss, ebp - 12]);         /* movsx eax, byte [ebp-0xc] */
            ii(0x100e_fe6d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_fe6f, 2); if(jl(0x100e_fe8f, 0x1e)) goto l_0x100e_fe8f; /* jl 0x100efe8f */
            ii(0x100e_fe71, 4); movsx(ebx, memb[ss, ebp - 12]);         /* movsx ebx, byte [ebp-0xc] */
            ii(0x100e_fe75, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100e_fe78, 3); inc(memd[ss, ebp - 20]);                /* inc dword [ebp-0x14] */
            ii(0x100e_fe7b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_fe7d, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x100e_fe7f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_fe82, 3); mov(eax, memd[ds, eax + 76]);           /* mov eax, [eax+0x4c] */
            ii(0x100e_fe85, 3); add(eax, memd[ss, ebp - 16]);           /* add eax, [ebp-0x10] */
            ii(0x100e_fe88, 5); call(Definitions.sys_memset, 0x7_5f53); /* call 0x10165de0 */
            ii(0x100e_fe8d, 2); jmp(0x100e_feae, 0x1f); goto l_0x100e_feae; /* jmp 0x100efeae */
        l_0x100e_fe8f:
            ii(0x100e_fe8f, 3); neg(memb[ss, ebp - 12]);                /* neg byte [ebp-0xc] */
            ii(0x100e_fe92, 4); movsx(ebx, memb[ss, ebp - 12]);         /* movsx ebx, byte [ebp-0xc] */
            ii(0x100e_fe96, 3); mov(edx, memd[ss, ebp - 20]);           /* mov edx, [ebp-0x14] */
            ii(0x100e_fe99, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_fe9c, 3); mov(eax, memd[ds, eax + 76]);           /* mov eax, [eax+0x4c] */
            ii(0x100e_fe9f, 3); add(eax, memd[ss, ebp - 16]);           /* add eax, [ebp-0x10] */
            ii(0x100e_fea2, 5); call(Definitions.sys_memcpy, 0x7_5fa4); /* call 0x10165e4b */
            ii(0x100e_fea7, 4); movsx(eax, memb[ss, ebp - 12]);         /* movsx eax, byte [ebp-0xc] */
            ii(0x100e_feab, 3); add(memd[ss, ebp - 20], eax);           /* add [ebp-0x14], eax */
        l_0x100e_feae:
            ii(0x100e_feae, 4); movsx(eax, memb[ss, ebp - 12]);         /* movsx eax, byte [ebp-0xc] */
            ii(0x100e_feb2, 3); add(memd[ss, ebp - 16], eax);           /* add [ebp-0x10], eax */
            ii(0x100e_feb5, 2); jmp(0x100e_fe49, -0x6e); goto l_0x100e_fe49; /* jmp 0x100efe49 */
        l_0x100e_feb7:
            ii(0x100e_feb7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_feba, 3); mov(eax, memd[ds, eax + 103]);          /* mov eax, [eax+0x67] */
            ii(0x100e_febd, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_fec0, 3); add(memd[ss, ebp - 24], eax);           /* add [ebp-0x18], eax */
            ii(0x100e_fec3, 5); jmp(0x100e_fe25, -0xa3); goto l_0x100e_fe25; /* jmp 0x100efe25 */
        l_0x100e_fec8:
            ii(0x100e_fec8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_feca, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_fecb, 1); pop(edi);                               /* pop edi */
            ii(0x100e_fecc, 1); pop(esi);                               /* pop esi */
            ii(0x100e_fecd, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_fece, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_fecf, 1); ret();                                  /* ret */
        }
    }
}
