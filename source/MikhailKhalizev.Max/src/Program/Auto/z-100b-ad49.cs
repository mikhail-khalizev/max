using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_ad49-47174361")]
        public void Method_100b_ad49()
        {
            ii(0x100b_ad49, 5); push(0x40);                             /* push 0x40 */
            ii(0x100b_ad4e, 5); call(Definitions.sys_check_available_stack_size, 0xa_afff); /* call 0x10165d52 */
            ii(0x100b_ad53, 1); push(ebx);                              /* push ebx */
            ii(0x100b_ad54, 1); push(ecx);                              /* push ecx */
            ii(0x100b_ad55, 1); push(edx);                              /* push edx */
            ii(0x100b_ad56, 1); push(esi);                              /* push esi */
            ii(0x100b_ad57, 1); push(edi);                              /* push edi */
            ii(0x100b_ad58, 1); push(ebp);                              /* push ebp */
            ii(0x100b_ad59, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_ad5b, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x100b_ad61, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100b_ad64, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_ad69, 5); call(0x1008_a768, -0x3_0606);           /* call 0x1008a768 */
            ii(0x100b_ad6e, 3); lea(ebx, memd[ss, ebp - 0x14]);         /* lea ebx, [ebp-0x14] */
            ii(0x100b_ad71, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_ad73, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_ad75, 5); call(0x1008_ae70, -0x2_ff0a);           /* call 0x1008ae70 */
            ii(0x100b_ad7a, 7); mov(memd[ss, ebp - 8], 0);              /* mov dword [ebp-0x8], 0x0 */
            ii(0x100b_ad81, 2); jmp(0x100b_ad89, 6); goto l_0x100b_ad89; /* jmp 0x100bad89 */
        l_0x100b_ad83:
            ii(0x100b_ad83, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_ad86, 3); inc(memd[ss, ebp - 8]);                 /* inc dword [ebp-0x8] */
        l_0x100b_ad89:
            ii(0x100b_ad89, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100b_ad8d, 3); cmp(eax, 3);                            /* cmp eax, 0x3 */
            ii(0x100b_ad90, 2); if(jge(0x100b_adaa, 0x18)) goto l_0x100b_adaa; /* jge 0x100badaa */
            ii(0x100b_ad92, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_ad94, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100b_ad98, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100b_ad9b, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x100b_ad9e, 3); add(ebx, 0x37);                         /* add ebx, 0x37 */
            ii(0x100b_ada1, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100b_ada3, 5); call(0x1008_afe4, -0x2_fdc4);           /* call 0x1008afe4 */
            ii(0x100b_ada8, 2); jmp(0x100b_ad83, -0x27); goto l_0x100b_ad83; /* jmp 0x100bad83 */
        l_0x100b_adaa:
            ii(0x100b_adaa, 2); jmp(0x100b_adb4, 8); goto l_0x100b_adb4; /* jmp 0x100badb4 */
        l_0x100b_adac:
            ii(0x100b_adac, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_adaf, 5); call(0x1007_6bf8, -0x4_41bc);           /* call 0x10076bf8 */
        l_0x100b_adb4:
            ii(0x100b_adb4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_adb6, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_adb9, 5); call(0x1013_ad71, 0x7_ffb3);            /* call 0x1013ad71 */
            ii(0x100b_adbe, 2); test(al, al);                           /* test al, al */
            ii(0x100b_adc0, 6); if(jz(0x100b_af22, 0x15c)) goto l_0x100b_af22; /* jz 0x100baf22 */
            ii(0x100b_adc6, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_adc9, 5); call(0x1008_adc4, -0x3_000a);           /* call 0x1008adc4 */
            ii(0x100b_adce, 5); call(0x1008_ad90, -0x3_0043);           /* call 0x1008ad90 */
            ii(0x100b_add3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_add5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_add8, 3); cmp(dx, memw[ds, eax]);                 /* cmp dx, [eax] */
            ii(0x100b_addb, 2); if(jnz(0x100b_adf8, 0x1b)) goto l_0x100b_adf8; /* jnz 0x100badf8 */
            ii(0x100b_addd, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_ade0, 5); call(0x1008_adc4, -0x3_0021);           /* call 0x1008adc4 */
            ii(0x100b_ade5, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100b_ade8, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100b_adeb, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x100b_adee, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100b_adf1, 3); call_abs(memd[ds, edx + 0x20]);         /* call dword [edx+0x20] */
            ii(0x100b_adf4, 2); cmp(al, 2);                             /* cmp al, 0x2 */
            ii(0x100b_adf6, 2); if(jz(0x100b_adfd, 5)) goto l_0x100b_adfd; /* jz 0x100badfd */
        l_0x100b_adf8:
            ii(0x100b_adf8, 5); jmp(0x100b_af1d, 0x120); goto l_0x100b_af1d; /* jmp 0x100baf1d */
        l_0x100b_adfd:
            ii(0x100b_adfd, 7); mov(memd[ss, ebp - 8], 0);              /* mov dword [ebp-0x8], 0x0 */
            ii(0x100b_ae04, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_ae07, 5); call(0x1008_adc4, -0x3_0048);           /* call 0x1008adc4 */
            ii(0x100b_ae0c, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100b_ae0f, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100b_ae12, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x100b_ae15, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100b_ae18, 3); call_abs(memd[ds, edx + 0x14]);         /* call dword [edx+0x14] */
            ii(0x100b_ae1b, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
        l_0x100b_ae1e:
            ii(0x100b_ae1e, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100b_ae22, 3); cmp(eax, 3);                            /* cmp eax, 0x3 */
            ii(0x100b_ae25, 2); if(jge(0x100b_ae41, 0x1a)) goto l_0x100b_ae41; /* jge 0x100bae41 */
            ii(0x100b_ae27, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_ae29, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100b_ae2d, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100b_ae30, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x100b_ae33, 3); add(ebx, 0x37);                         /* add ebx, 0x37 */
            ii(0x100b_ae36, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100b_ae38, 5); call(0x1013_ad71, 0x7_ff34);            /* call 0x1013ad71 */
            ii(0x100b_ae3d, 2); test(al, al);                           /* test al, al */
            ii(0x100b_ae3f, 2); if(jnz(0x100b_ae43, 2)) goto l_0x100b_ae43; /* jnz 0x100bae43 */
        l_0x100b_ae41:
            ii(0x100b_ae41, 2); jmp(0x100b_ae65, 0x22); goto l_0x100b_ae65; /* jmp 0x100bae65 */
        l_0x100b_ae43:
            ii(0x100b_ae43, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100b_ae47, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100b_ae4b, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100b_ae4e, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x100b_ae51, 3); add(ebx, 0x37);                         /* add ebx, 0x37 */
            ii(0x100b_ae54, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100b_ae56, 5); call(0x1008_af28, -0x2_ff33);           /* call 0x1008af28 */
            ii(0x100b_ae5b, 5); call(0x100a_2bc4, -0x1_829c);           /* call 0x100a2bc4 */
            ii(0x100b_ae60, 1); cwde();                                 /* cwde */
            ii(0x100b_ae61, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_ae63, 2); if(jle(0x100b_ae67, 2)) goto l_0x100b_ae67; /* jle 0x100bae67 */
        l_0x100b_ae65:
            ii(0x100b_ae65, 2); jmp(0x100b_ae6f, 8); goto l_0x100b_ae6f; /* jmp 0x100bae6f */
        l_0x100b_ae67:
            ii(0x100b_ae67, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_ae6a, 3); inc(memd[ss, ebp - 8]);                 /* inc dword [ebp-0x8] */
            ii(0x100b_ae6d, 2); jmp(0x100b_ae1e, -0x51); goto l_0x100b_ae1e; /* jmp 0x100bae1e */
        l_0x100b_ae6f:
            ii(0x100b_ae6f, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100b_ae73, 3); cmp(eax, 3);                            /* cmp eax, 0x3 */
            ii(0x100b_ae76, 2); if(jnz(0x100b_ae94, 0x1c)) goto l_0x100b_ae94; /* jnz 0x100bae94 */
            ii(0x100b_ae78, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_ae7b, 5); call(0x1008_adc4, -0x3_00bc);           /* call 0x1008adc4 */
            ii(0x100b_ae80, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x100b_ae83, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100b_ae86, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x100b_ae89, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100b_ae8c, 3); call_abs(memd[ds, edx + 0x48]);         /* call dword [edx+0x48] */
            ii(0x100b_ae8f, 5); jmp(0x100b_af1d, 0x89); goto l_0x100b_af1d; /* jmp 0x100baf1d */
        l_0x100b_ae94:
            ii(0x100b_ae94, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_ae96, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_ae99, 3); add(eax, 0x3f);                         /* add eax, 0x3f */
            ii(0x100b_ae9c, 5); call(0x1013_ad71, 0x7_fed0);            /* call 0x1013ad71 */
            ii(0x100b_aea1, 2); test(al, al);                           /* test al, al */
            ii(0x100b_aea3, 2); if(jz(0x100b_aebf, 0x1a)) goto l_0x100b_aebf; /* jz 0x100baebf */
            ii(0x100b_aea5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_aea8, 3); add(eax, 0x3f);                         /* add eax, 0x3f */
            ii(0x100b_aeab, 5); call(0x1008_af28, -0x2_ff88);           /* call 0x1008af28 */
            ii(0x100b_aeb0, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x100b_aeb3, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x100b_aeb6, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x100b_aeb9, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x100b_aebc, 3); call_abs(memd[ds, edx + 0x48]);         /* call dword [edx+0x48] */
        l_0x100b_aebf:
            ii(0x100b_aebf, 7); mov(memd[ss, ebp - 0xc], 2);            /* mov dword [ebp-0xc], 0x2 */
            ii(0x100b_aec6, 2); jmp(0x100b_aece, 6); goto l_0x100b_aece; /* jmp 0x100baece */
        l_0x100b_aec8:
            ii(0x100b_aec8, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_aecb, 3); dec(memd[ss, ebp - 0xc]);               /* dec dword [ebp-0xc] */
        l_0x100b_aece:
            ii(0x100b_aece, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_aed1, 4); cmp(ax, memw[ss, ebp - 8]);             /* cmp ax, [ebp-0x8] */
            ii(0x100b_aed5, 2); if(jle(0x100b_aeff, 0x28)) goto l_0x100b_aeff; /* jle 0x100baeff */
            ii(0x100b_aed7, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x100b_aedb, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100b_aede, 3); sub(eax, 4);                            /* sub eax, 0x4 */
            ii(0x100b_aee1, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100b_aee4, 3); add(edx, 0x37);                         /* add edx, 0x37 */
            ii(0x100b_aee7, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100b_aee9, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x100b_aeed, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100b_aef0, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x100b_aef3, 3); add(ebx, 0x37);                         /* add ebx, 0x37 */
            ii(0x100b_aef6, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100b_aef8, 5); call(0x100a_b230, -0xfccd);             /* call 0x100ab230 */
            ii(0x100b_aefd, 2); jmp(0x100b_aec8, -0x37); goto l_0x100b_aec8; /* jmp 0x100baec8 */
        l_0x100b_aeff:
            ii(0x100b_aeff, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_af02, 5); call(0x1008_adf8, -0x3_010f);           /* call 0x1008adf8 */
            ii(0x100b_af07, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_af09, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100b_af0d, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100b_af10, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x100b_af13, 3); add(ebx, 0x37);                         /* add ebx, 0x37 */
            ii(0x100b_af16, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100b_af18, 5); call(0x1008_afe4, -0x2_ff39);           /* call 0x1008afe4 */
        l_0x100b_af1d:
            ii(0x100b_af1d, 5); jmp(0x100b_adac, -0x176); goto l_0x100b_adac; /* jmp 0x100badac */
        l_0x100b_af22:
            ii(0x100b_af22, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_af24, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_af27, 5); call(0x1008_8bbc, -0x3_2370);           /* call 0x10088bbc */
            ii(0x100b_af2c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_af2e, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_af2f, 1); pop(edi);                               /* pop edi */
            ii(0x100b_af30, 1); pop(esi);                               /* pop esi */
            ii(0x100b_af31, 1); pop(edx);                               /* pop edx */
            ii(0x100b_af32, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_af33, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_af34, 1); ret();                                  /* ret */
        }
    }
}
