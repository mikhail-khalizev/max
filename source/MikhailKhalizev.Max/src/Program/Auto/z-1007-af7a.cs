using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_af7a-7e25abc9")]
        public void Method_1007_af7a()
        {
            ii(0x1007_af7a, 5); push(0x28);                             /* push 0x28 */
            ii(0x1007_af7f, 5); call(Definitions.sys_check_available_stack_size, 0xe_adce); /* call 0x10165d52 */
            ii(0x1007_af84, 1); push(ebx);                              /* push ebx */
            ii(0x1007_af85, 1); push(ecx);                              /* push ecx */
            ii(0x1007_af86, 1); push(esi);                              /* push esi */
            ii(0x1007_af87, 1); push(edi);                              /* push edi */
            ii(0x1007_af88, 1); push(ebp);                              /* push ebp */
            ii(0x1007_af89, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_af8b, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1007_af91, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_af94, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_af97, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_af9a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_af9d, 5); call(0x1007_8789, -0x2819);             /* call 0x10078789 */
            ii(0x1007_afa2, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1007_afa5, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_afa8, 5); call(0x1007_623c, -0x4d71);             /* call 0x1007623c */
            ii(0x1007_afad, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_afaf, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_afb2, 5); imul(ax, memw[ds, edx + 0x14]);         /* imul ax, [edx+0x14] */
            ii(0x1007_afb7, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1007_afba, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_afbd, 5); call(0x1007_623c, -0x4d86);             /* call 0x1007623c */
            ii(0x1007_afc2, 3); mov(eax, memd[ds, eax + 0xc]);          /* mov eax, [eax+0xc] */
            ii(0x1007_afc5, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_afc8, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_afca, 2); if(jle(0x1007_b021, 0x55)) goto l_0x1007_b021; /* jle 0x1007b021 */
            ii(0x1007_afcc, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_afcf, 5); call(0x1007_623c, -0x4d98);             /* call 0x1007623c */
            ii(0x1007_afd4, 3); mov(eax, memd[ds, eax + 0xe]);          /* mov eax, [eax+0xe] */
            ii(0x1007_afd7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_afda, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_afdc, 2); if(jnz(0x1007_affa, 0x1c)) goto l_0x1007_affa; /* jnz 0x1007affa */
            ii(0x1007_afde, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_afe1, 5); call(0x1007_623c, -0x4daa);             /* call 0x1007623c */
            ii(0x1007_afe6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_afe8, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_afeb, 5); call(0x1007_623c, -0x4db4);             /* call 0x1007623c */
            ii(0x1007_aff0, 4); mov(dx, memw[ds, edx + 0x12]);          /* mov dx, [edx+0x12] */
            ii(0x1007_aff4, 4); cmp(dx, memw[ds, eax + 0x12]);          /* cmp dx, [eax+0x12] */
            ii(0x1007_aff8, 2); if(jg(0x1007_b015, 0x1b)) goto l_0x1007_b015; /* jg 0x1007b015 */
        l_0x1007_affa:
            ii(0x1007_affa, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_affd, 3); mov(edx, memd[ds, eax + 0x6]);          /* mov edx, [eax+0x6] */
            ii(0x1007_b000, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1007_b003, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_b006, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x1007_b009, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_b00c, 5); call(0x1007_49d4, -0x663d);             /* call 0x100749d4 */
            ii(0x1007_b011, 2); test(al, al);                           /* test al, al */
            ii(0x1007_b013, 2); if(jnz(0x1007_b021, 0xc)) goto l_0x1007_b021; /* jnz 0x1007b021 */
        l_0x1007_b015:
            ii(0x1007_b015, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_b018, 3); mov(al, memb[ds, eax + 0x4d]);          /* mov al, [eax+0x4d] */
            ii(0x1007_b01b, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1007_b01d, 1); dec(eax);                               /* dec eax */
            ii(0x1007_b01e, 3); add(memd[ss, ebp - 0xc], eax);          /* add [ebp-0xc], eax */
        l_0x1007_b021:
            ii(0x1007_b021, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_b024, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_b027, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_b02a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_b02c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_b02d, 1); pop(edi);                               /* pop edi */
            ii(0x1007_b02e, 1); pop(esi);                               /* pop esi */
            ii(0x1007_b02f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_b030, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_b031, 1); ret();                                  /* ret */
        }
    }
}
