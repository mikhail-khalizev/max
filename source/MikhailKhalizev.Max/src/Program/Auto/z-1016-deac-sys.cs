using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_deac-d72bf4cd")]
        public void /* sys */ Method_1016_deac()
        {
            ii(0x1016_deac, 1); push(ebx);                              /* push ebx */
            ii(0x1016_dead, 1); push(ecx);                              /* push ecx */
            ii(0x1016_deae, 1); push(edx);                              /* push edx */
            ii(0x1016_deaf, 1); push(esi);                              /* push esi */
            ii(0x1016_deb0, 1); push(edi);                              /* push edi */
            ii(0x1016_deb1, 1); push(ebp);                              /* push ebp */
            ii(0x1016_deb2, 3); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1016_deb5, 6); mov(edx, memd[ds, 0x1020_8524]);        /* mov edx, [0x10208524] */
            ii(0x1016_debb, 6); mov(ebp, memd[ds, 0x1020_8534]);        /* mov ebp, [0x10208534] */
            ii(0x1016_dec1, 4); mov(memd[ss, esp + 0x4], edx);          /* mov [esp+0x4], edx */
            ii(0x1016_dec5, 2); add(ebp, ebp);                          /* add ebp, ebp */
            ii(0x1016_dec7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_dec9, 2); if(jz(0x1016_def2, 0x27)) goto l_0x1016_def2; /* jz 0x1016def2 */
            ii(0x1016_decb, 5); mov(eax, memd[ds, 0x1020_855c]);        /* mov eax, [0x1020855c] */
            ii(0x1016_ded0, 5); mov(memd[ds, 0x1020_88b4], eax);        /* mov [0x102088b4], eax */
            ii(0x1016_ded5, 5); mov(eax, memd[ds, 0x1020_8530]);        /* mov eax, [0x10208530] */
            ii(0x1016_deda, 1); dec(eax);                               /* dec eax */
            ii(0x1016_dedb, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_dedd, 5); mov(memd[ds, 0x1020_88ac], eax);        /* mov [0x102088ac], eax */
            ii(0x1016_dee2, 5); mov(eax, memd[ds, 0x1020_8548]);        /* mov eax, [0x10208548] */
            ii(0x1016_dee7, 6); mov(memd[ds, 0x1020_88b0], ebx);        /* mov [0x102088b0], ebx */
            ii(0x1016_deed, 5); mov(memd[ds, 0x1020_88a8], eax);        /* mov [0x102088a8], eax */
        l_0x1016_def2:
            ii(0x1016_def2, 6); mov(ebx, memd[ds, 0x1020_88b4]);        /* mov ebx, [0x102088b4] */
            ii(0x1016_def8, 5); mov(eax, memd[ds, 0x1020_8574]);        /* mov eax, [0x10208574] */
            ii(0x1016_defd, 6); mov(esi, memd[ds, 0x1020_88a8]);        /* mov esi, [0x102088a8] */
            ii(0x1016_df03, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_df05, 6); mov(edx, memd[ds, 0x1020_8560]);        /* mov edx, [0x10208560] */
            ii(0x1016_df0b, 3); mov(memd[ss, esp], ecx);                /* mov [esp], ecx */
            ii(0x1016_df0e, 6); mov(ecx, memd[ds, 0x1020_88ac]);        /* mov ecx, [0x102088ac] */
            ii(0x1016_df14, 6); mov(edi, memd[ds, 0x1020_8570]);        /* mov edi, [0x10208570] */
            ii(0x1016_df1a, 4); mov(memd[ss, esp + 0xc], ecx);          /* mov [esp+0xc], ecx */
            ii(0x1016_df1e, 2); cmp(ebx, ecx);                          /* cmp ebx, ecx */
            ii(0x1016_df20, 2); if(jg(0x1016_df7d, 0x5b)) goto l_0x1016_df7d; /* jg 0x1016df7d */
        l_0x1016_df22:
            ii(0x1016_df22, 2); cmp(eax, memd[ds, edx]);                /* cmp eax, [edx] */
            ii(0x1016_df24, 2); if(jae(0x1016_df54, 0x2e)) goto l_0x1016_df54; /* jae 0x1016df54 */
            ii(0x1016_df26, 6); cmp(ebx, memd[ds, 0x1020_88b4]);        /* cmp ebx, [0x102088b4] */
            ii(0x1016_df2c, 2); if(jle(0x1016_df4b, 0x1d)) goto l_0x1016_df4b; /* jle 0x1016df4b */
            ii(0x1016_df2e, 6); mov(memd[ds, 0x1020_88b4], ebx);        /* mov [0x102088b4], ebx */
            ii(0x1016_df34, 6); mov(memd[ds, 0x1020_8560], edx);        /* mov [0x10208560], edx */
            ii(0x1016_df3a, 6); mov(memd[ds, 0x1020_8570], edi);        /* mov [0x10208570], edi */
            ii(0x1016_df40, 5); mov(memd[ds, 0x1020_8574], eax);        /* mov [0x10208574], eax */
            ii(0x1016_df45, 6); mov(memd[ds, 0x1020_88a8], esi);        /* mov [0x102088a8], esi */
        l_0x1016_df4b:
            ii(0x1016_df4b, 7); mov(memd[ss, esp], 0x1);                /* mov dword [esp], 0x1 */
            ii(0x1016_df52, 2); jmp(0x1016_df7d, 0x29); goto l_0x1016_df7d; /* jmp 0x1016df7d */
        l_0x1016_df54:
            ii(0x1016_df54, 4); mov(ecx, memd[ss, esp + 0xc]);          /* mov ecx, [esp+0xc] */
            ii(0x1016_df58, 1); inc(ebx);                               /* inc ebx */
            ii(0x1016_df59, 3); add(edx, 0x4);                          /* add edx, 0x4 */
            ii(0x1016_df5c, 1); inc(edi);                               /* inc edi */
            ii(0x1016_df5d, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1016_df5f, 2); add(esi, ebp);                          /* add esi, ebp */
            ii(0x1016_df61, 2); cmp(ebx, ecx);                          /* cmp ebx, ecx */
            ii(0x1016_df63, 2); if(jle(0x1016_df22, -0x43)) goto l_0x1016_df22; /* jle 0x1016df22 */
            ii(0x1016_df65, 2); jmp(0x1016_df7d, 0x16); goto l_0x1016_df7d; /* jmp 0x1016df7d */
        l_0x1016_df67:
            ii(0x1016_df67, 2); cmp(eax, memd[ds, edx]);                /* cmp eax, [edx] */
            ii(0x1016_df69, 2); if(jae(0x1016_df83, 0x18)) goto l_0x1016_df83; /* jae 0x1016df83 */
            ii(0x1016_df6b, 4); mov(cl, memb[ss, esp + 0x4]);           /* mov cl, [esp+0x4] */
            ii(0x1016_df6f, 1); inc(ebx);                               /* inc ebx */
            ii(0x1016_df70, 1); inc(edi);                               /* inc edi */
            ii(0x1016_df71, 2); mov(memd[ds, edx], eax);                /* mov [edx], eax */
            ii(0x1016_df73, 3); add(edx, 0x4);                          /* add edx, 0x4 */
            ii(0x1016_df76, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1016_df78, 3); mov(memb[ds, edi - 0x1], cl);           /* mov [edi-0x1], cl */
            ii(0x1016_df7b, 2); add(esi, ebp);                          /* add esi, ebp */
        l_0x1016_df7d:
            ii(0x1016_df7d, 4); cmp(ebx, memd[ss, esp + 0xc]);          /* cmp ebx, [esp+0xc] */
            ii(0x1016_df81, 2); if(jle(0x1016_df67, -0x1c)) goto l_0x1016_df67; /* jle 0x1016df67 */
        l_0x1016_df83:
            ii(0x1016_df83, 3); mov(ecx, memd[ss, esp]);                /* mov ecx, [esp] */
            ii(0x1016_df86, 5); mov(eax, memd[ds, 0x1020_88b0]);        /* mov eax, [0x102088b0] */
            ii(0x1016_df8b, 6); mov(esi, memd[ds, 0x1020_88b4]);        /* mov esi, [0x102088b4] */
            ii(0x1016_df91, 6); mov(ebx, memd[ds, 0x1020_88a8]);        /* mov ebx, [0x102088a8] */
            ii(0x1016_df97, 6); mov(edx, memd[ds, 0x1020_8574]);        /* mov edx, [0x10208574] */
            ii(0x1016_df9d, 6); mov(edi, memd[ds, 0x1020_8570]);        /* mov edi, [0x10208570] */
            ii(0x1016_dfa3, 4); mov(memd[ss, esp + 0x8], eax);          /* mov [esp+0x8], eax */
            ii(0x1016_dfa7, 1); dec(esi);                               /* dec esi */
            ii(0x1016_dfa8, 1); dec(edi);                               /* dec edi */
            ii(0x1016_dfa9, 2); sub(ebx, ebp);                          /* sub ebx, ebp */
            ii(0x1016_dfab, 5); mov(eax, memd[ds, 0x1020_8560]);        /* mov eax, [0x10208560] */
            ii(0x1016_dfb0, 2); sub(edx, ebx);                          /* sub edx, ebx */
            ii(0x1016_dfb2, 3); sub(eax, 0x4);                          /* sub eax, 0x4 */
            ii(0x1016_dfb5, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1016_dfb7, 2); if(jz(0x1016_dfef, 0x36)) goto l_0x1016_dfef; /* jz 0x1016dfef */
            ii(0x1016_dfb9, 2); jmp(0x1016_e00d, 0x52); goto l_0x1016_e00d; /* jmp 0x1016e00d */
        l_0x1016_dfbb:
            ii(0x1016_dfbb, 2); cmp(edx, memd[ds, eax]);                /* cmp edx, [eax] */
            ii(0x1016_dfbd, 2); if(jae(0x1016_dfe6, 0x27)) goto l_0x1016_dfe6; /* jae 0x1016dfe6 */
            ii(0x1016_dfbf, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1016_dfc4, 6); mov(memd[ds, 0x1020_88b4], esi);        /* mov [0x102088b4], esi */
            ii(0x1016_dfca, 5); mov(memd[ds, 0x1020_8560], eax);        /* mov [0x10208560], eax */
            ii(0x1016_dfcf, 6); mov(memd[ds, 0x1020_8570], edi);        /* mov [0x10208570], edi */
            ii(0x1016_dfd5, 6); mov(memd[ds, 0x1020_8574], edx);        /* mov [0x10208574], edx */
            ii(0x1016_dfdb, 6); mov(memd[ds, 0x1020_88a8], ebx);        /* mov [0x102088a8], ebx */
            ii(0x1016_dfe1, 3); mov(memd[ss, esp], ecx);                /* mov [esp], ecx */
            ii(0x1016_dfe4, 2); jmp(0x1016_e00d, 0x27); goto l_0x1016_e00d; /* jmp 0x1016e00d */
        l_0x1016_dfe6:
            ii(0x1016_dfe6, 1); dec(esi);                               /* dec esi */
            ii(0x1016_dfe7, 3); sub(eax, 0x4);                          /* sub eax, 0x4 */
            ii(0x1016_dfea, 2); sub(ebx, ebp);                          /* sub ebx, ebp */
            ii(0x1016_dfec, 1); dec(edi);                               /* dec edi */
            ii(0x1016_dfed, 2); sub(edx, ebx);                          /* sub edx, ebx */
        l_0x1016_dfef:
            ii(0x1016_dfef, 4); cmp(esi, memd[ss, esp + 0x8]);          /* cmp esi, [esp+0x8] */
            ii(0x1016_dff3, 2); if(jge(0x1016_dfbb, -0x3a)) goto l_0x1016_dfbb; /* jge 0x1016dfbb */
            ii(0x1016_dff5, 2); jmp(0x1016_e00d, 0x16); goto l_0x1016_e00d; /* jmp 0x1016e00d */
        l_0x1016_dff7:
            ii(0x1016_dff7, 2); cmp(edx, memd[ds, eax]);                /* cmp edx, [eax] */
            ii(0x1016_dff9, 2); if(jae(0x1016_e013, 0x18)) goto l_0x1016_e013; /* jae 0x1016e013 */
            ii(0x1016_dffb, 4); mov(cl, memb[ss, esp + 0x4]);           /* mov cl, [esp+0x4] */
            ii(0x1016_dfff, 1); dec(esi);                               /* dec esi */
            ii(0x1016_e000, 1); dec(edi);                               /* dec edi */
            ii(0x1016_e001, 2); sub(ebx, ebp);                          /* sub ebx, ebp */
            ii(0x1016_e003, 2); mov(memd[ds, eax], edx);                /* mov [eax], edx */
            ii(0x1016_e005, 3); sub(eax, 0x4);                          /* sub eax, 0x4 */
            ii(0x1016_e008, 2); sub(edx, ebx);                          /* sub edx, ebx */
            ii(0x1016_e00a, 3); mov(memb[ds, edi + 0x1], cl);           /* mov [edi+0x1], cl */
        l_0x1016_e00d:
            ii(0x1016_e00d, 4); cmp(esi, memd[ss, esp + 0x8]);          /* cmp esi, [esp+0x8] */
            ii(0x1016_e011, 2); if(jge(0x1016_dff7, -0x1c)) goto l_0x1016_dff7; /* jge 0x1016dff7 */
        l_0x1016_e013:
            ii(0x1016_e013, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1016_e016, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1016_e019, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_e01a, 1); pop(edi);                               /* pop edi */
            ii(0x1016_e01b, 1); pop(esi);                               /* pop esi */
            ii(0x1016_e01c, 1); pop(edx);                               /* pop edx */
            ii(0x1016_e01d, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_e01e, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_e01f, 1); ret();                                  /* ret */
        }
    }
}
