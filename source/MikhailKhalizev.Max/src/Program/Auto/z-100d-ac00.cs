using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_ac00-74cb7931")]
        public void Method_100d_ac00()
        {
            ii(0x100d_ac00, 5); push(0x24);                             /* push 0x24 */
            ii(0x100d_ac05, 5); call(Definitions.sys_check_available_stack_size, 0x8_b148); /* call 0x10165d52 */
            ii(0x100d_ac0a, 1); push(ebx);                              /* push ebx */
            ii(0x100d_ac0b, 1); push(ecx);                              /* push ecx */
            ii(0x100d_ac0c, 1); push(edx);                              /* push edx */
            ii(0x100d_ac0d, 1); push(esi);                              /* push esi */
            ii(0x100d_ac0e, 1); push(edi);                              /* push edi */
            ii(0x100d_ac0f, 1); push(ebp);                              /* push ebp */
            ii(0x100d_ac10, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_ac12, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100d_ac18, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100d_ac1b, 7); mov(memd[ss, ebp - 8], 0);              /* mov dword [ebp-0x8], 0x0 */
            ii(0x100d_ac22, 2); jmp(0x100d_ac2a, 6); goto l_0x100d_ac2a; /* jmp 0x100dac2a */
        l_0x100d_ac24:
            ii(0x100d_ac24, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_ac27, 3); inc(memd[ss, ebp - 8]);                 /* inc dword [ebp-0x8] */
        l_0x100d_ac2a:
            ii(0x100d_ac2a, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100d_ac2e, 3); cmp(eax, 0x5d);                         /* cmp eax, 0x5d */
            ii(0x100d_ac31, 6); if(jge(0x100d_ad04, 0xcd)) goto l_0x100d_ad04; /* jge 0x100dad04 */
            ii(0x100d_ac37, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x100d_ac3b, 3); shl(edx, 2);                            /* shl edx, 0x2 */
            ii(0x100d_ac3e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_ac41, 5); add(eax, 0x1cf);                        /* add eax, 0x1cf */
            ii(0x100d_ac46, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_ac48, 5); call(0x100c_b6f0, -0xf55d);             /* call 0x100cb6f0 */
            ii(0x100d_ac4d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_ac4f, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100d_ac53, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100d_ac56, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100d_ac58, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_ac5b, 3); add(eax, 0x5b);                         /* add eax, 0x5b */
            ii(0x100d_ac5e, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100d_ac60, 5); call(0x100c_b6f0, -0xf575);             /* call 0x100cb6f0 */
            ii(0x100d_ac65, 5); call(0x1016_3d92, 0x8_9128);            /* call 0x10163d92 */
            ii(0x100d_ac6a, 2); test(al, al);                           /* test al, al */
            ii(0x100d_ac6c, 6); if(jz(0x100d_acff, 0x8d)) goto l_0x100d_acff; /* jz 0x100dacff */
            ii(0x100d_ac72, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100d_ac76, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100d_ac79, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_ac7b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_ac7e, 5); add(eax, 0x1cf);                        /* add eax, 0x1cf */
            ii(0x100d_ac83, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_ac85, 5); call(0x1007_6730, -0x6_455a);           /* call 0x10076730 */
            ii(0x100d_ac8a, 5); call(0x100c_b7e4, -0xf4ab);             /* call 0x100cb7e4 */
            ii(0x100d_ac8f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_ac91, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100d_ac95, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100d_ac98, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x100d_ac9b, 6); add(ebx, 0x1cf);                        /* add ebx, 0x1cf */
            ii(0x100d_aca1, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100d_aca3, 5); call(0x1007_6730, -0x6_4578);           /* call 0x10076730 */
            ii(0x100d_aca8, 5); call(0x100c_b7b4, -0xf4f9);             /* call 0x100cb7b4 */
            ii(0x100d_acad, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100d_acb1, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100d_acb4, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100d_acb7, 6); add(edx, 0x1cf);                        /* add edx, 0x1cf */
            ii(0x100d_acbd, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_acbf, 5); call(0x1007_678c, -0x6_4538);           /* call 0x1007678c */
            ii(0x100d_acc4, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100d_acc6, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x100d_acca, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_accd, 3); mov(eax, memd[ds, eax + 73]);           /* mov eax, [eax+0x49] */
            ii(0x100d_acd0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_acd3, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100d_acd9, 6); mov(eax, memd[ds, eax + 0x101c_a562]);  /* mov eax, [eax+0x101ca562] */
            ii(0x100d_acdf, 5); call(0x100c_b63c, -0xf6a8);             /* call 0x100cb63c */
            ii(0x100d_ace4, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x100d_aceb, 2); if(jz(0x100d_acff, 0x12)) goto l_0x100d_acff; /* jz 0x100dacff */
            ii(0x100d_aced, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x100d_acf1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_acf4, 3); mov(eax, memd[ds, eax + 73]);           /* mov eax, [eax+0x49] */
            ii(0x100d_acf7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_acfa, 5); call(0x1012_8a34, 0x4_dd35);            /* call 0x10128a34 */
        l_0x100d_acff:
            ii(0x100d_acff, 5); jmp(0x100d_ac24, -0xe0); goto l_0x100d_ac24; /* jmp 0x100dac24 */
        l_0x100d_ad04:
            ii(0x100d_ad04, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_ad07, 3); mov(eax, memd[ds, eax + 73]);           /* mov eax, [eax+0x49] */
            ii(0x100d_ad0a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_ad0d, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100d_ad13, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100d_ad16, 4); mov(dx, memw[ds, edx + 77]);            /* mov dx, [edx+0x4d] */
            ii(0x100d_ad1a, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x100d_ad1d, 4); sub(dx, memw[ds, ebx + 79]);            /* sub dx, [ebx+0x4f] */
            ii(0x100d_ad21, 7); add(memw[ds, eax + 0x101c_a583], dx);   /* add [eax+0x101ca583], dx */
            ii(0x100d_ad28, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_ad2a, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_ad2b, 1); pop(edi);                               /* pop edi */
            ii(0x100d_ad2c, 1); pop(esi);                               /* pop esi */
            ii(0x100d_ad2d, 1); pop(edx);                               /* pop edx */
            ii(0x100d_ad2e, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_ad2f, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_ad30, 1); ret();                                  /* ret */
        }
    }
}
