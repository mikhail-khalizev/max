using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_dc08-5a20f588")]
        public void /* sys */ Method_1016_dc08()
        {
            ii(0x1016_dc08, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_dc09, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_dc0a, 1); pushd(edx);                             /* push edx */
            ii(0x1016_dc0b, 1); pushd(esi);                             /* push esi */
            ii(0x1016_dc0c, 1); pushd(edi);                             /* push edi */
            ii(0x1016_dc0d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_dc0e, 6); mov(esi, memd_a32[ds, 0x1020_8534]);    /* mov esi, [0x10208534] */
            ii(0x1016_dc14, 2); add(esi, esi);                          /* add esi, esi */
            ii(0x1016_dc16, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_dc18, 2); if(jzd(0x1016_dc41, 0x27)) goto l_0x1016_dc41; /* jz 0x1016dc41 */
            ii(0x1016_dc1a, 5); mov(eax, memd_a32[ds, 0x1020_8558]);    /* mov eax, [0x10208558] */
            ii(0x1016_dc1f, 5); mov(memd_a32[ds, 0x1020_88a4], eax);    /* mov [0x102088a4], eax */
            ii(0x1016_dc24, 5); mov(eax, memd_a32[ds, 0x1020_8530]);    /* mov eax, [0x10208530] */
            ii(0x1016_dc29, 1); dec(eax);                               /* dec eax */
            ii(0x1016_dc2a, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_dc2c, 5); mov(memd_a32[ds, 0x1020_889c], eax);    /* mov [0x1020889c], eax */
            ii(0x1016_dc31, 5); mov(eax, memd_a32[ds, 0x1020_854c]);    /* mov eax, [0x1020854c] */
            ii(0x1016_dc36, 6); mov(memd_a32[ds, 0x1020_88a0], ebx);    /* mov [0x102088a0], ebx */
            ii(0x1016_dc3c, 5); mov(memd_a32[ds, 0x1020_8898], eax);    /* mov [0x10208898], eax */
        l_0x1016_dc41:
            ii(0x1016_dc41, 6); mov(ebx, memd_a32[ds, 0x1020_88a4]);    /* mov ebx, [0x102088a4] */
            ii(0x1016_dc47, 5); mov(eax, memd_a32[ds, 0x1020_856c]);    /* mov eax, [0x1020856c] */
            ii(0x1016_dc4c, 6); mov(ecx, memd_a32[ds, 0x1020_8898]);    /* mov ecx, [0x10208898] */
            ii(0x1016_dc52, 5); mov(memd_a32[ds, 0x1020_8574], eax);    /* mov [0x10208574], eax */
            ii(0x1016_dc57, 5); mov(memd_a32[ds, 0x1020_8890], eax);    /* mov [0x10208890], eax */
            ii(0x1016_dc5c, 5); mov(eax, memd_a32[ds, 0x1020_8550]);    /* mov eax, [0x10208550] */
            ii(0x1016_dc61, 6); mov(edi, memd_a32[ds, 0x1020_889c]);    /* mov edi, [0x1020889c] */
            ii(0x1016_dc67, 5); mov(memd_a32[ds, 0x1020_8560], eax);    /* mov [0x10208560], eax */
            ii(0x1016_dc6c, 5); mov(memd_a32[ds, 0x1020_888c], eax);    /* mov [0x1020888c], eax */
            ii(0x1016_dc71, 5); mov(eax, memd_a32[ds, 0x1020_8538]);    /* mov eax, [0x10208538] */
            ii(0x1016_dc76, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_dc78, 5); mov(memd_a32[ds, 0x1020_8570], eax);    /* mov [0x10208570], eax */
            ii(0x1016_dc7d, 5); mov(memd_a32[ds, 0x1020_8888], eax);    /* mov [0x10208888], eax */
            ii(0x1016_dc82, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1016_dc87, 2); cmp(ebx, edi);                          /* cmp ebx, edi */
            ii(0x1016_dc89, 6); if(jgd(0x1016_dd65, 0xd6)) goto l_0x1016_dd65; /* jg 0x1016dd65 */
            ii(0x1016_dc8f, 6); mov(memd_a32[ds, 0x1020_8894], ecx);    /* mov [0x10208894], ecx */
        l_0x1016_dc95:
            ii(0x1016_dc95, 5); calld(/* sys */ 0x1016_deac, 0x212);    /* call 0x1016deac */
            ii(0x1016_dc9a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_dc9c, 2); if(jzd(0x1016_dce1, 0x43)) goto l_0x1016_dce1; /* jz 0x1016dce1 */
            ii(0x1016_dc9e, 6); mov(ecx, memd_a32[ds, 0x1020_8894]);    /* mov ecx, [0x10208894] */
            ii(0x1016_dca4, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1016_dca6, 2); if(jnzd(0x1016_dceb, 0x43)) goto l_0x1016_dceb; /* jnz 0x1016dceb */
            ii(0x1016_dca8, 6); cmp(ebx, memd_a32[ds, 0x1020_88a4]);    /* cmp ebx, [0x102088a4] */
            ii(0x1016_dcae, 2); if(jled(0x1016_dcda, 0x2a)) goto l_0x1016_dcda; /* jle 0x1016dcda */
            ii(0x1016_dcb0, 5); mov(eax, memd_a32[ds, 0x1020_888c]);    /* mov eax, [0x1020888c] */
            ii(0x1016_dcb5, 5); mov(memd_a32[ds, 0x1020_8550], eax);    /* mov [0x10208550], eax */
            ii(0x1016_dcba, 5); mov(eax, memd_a32[ds, 0x1020_8888]);    /* mov eax, [0x10208888] */
            ii(0x1016_dcbf, 6); mov(memd_a32[ds, 0x1020_88a4], ebx);    /* mov [0x102088a4], ebx */
            ii(0x1016_dcc5, 5); mov(memd_a32[ds, 0x1020_8538], eax);    /* mov [0x10208538], eax */
            ii(0x1016_dcca, 5); mov(eax, memd_a32[ds, 0x1020_8890]);    /* mov eax, [0x10208890] */
            ii(0x1016_dccf, 6); mov(memd_a32[ds, 0x1020_8898], ecx);    /* mov [0x10208898], ecx */
            ii(0x1016_dcd5, 5); mov(memd_a32[ds, 0x1020_856c], eax);    /* mov [0x1020856c], eax */
        l_0x1016_dcda:
            ii(0x1016_dcda, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1016_dcdf, 2); jmpd(0x1016_dceb, 0xa); goto l_0x1016_dceb; /* jmp 0x1016dceb */
        l_0x1016_dce1:
            ii(0x1016_dce1, 6); mov(ecx, memd_a32[ds, 0x1020_8894]);    /* mov ecx, [0x10208894] */
            ii(0x1016_dce7, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1016_dce9, 2); if(jnzd(0x1016_dd65, 0x7a)) goto l_0x1016_dd65; /* jnz 0x1016dd65 */
        l_0x1016_dceb:
            ii(0x1016_dceb, 5); mov(eax, memd_a32[ds, 0x1020_853c]);    /* mov eax, [0x1020853c] */
            ii(0x1016_dcf0, 6); mov(ebp, memd_a32[ds, 0x1020_8560]);    /* mov ebp, [0x10208560] */
            ii(0x1016_dcf6, 6); mov(edi, memd_a32[ds, 0x1020_888c]);    /* mov edi, [0x1020888c] */
            ii(0x1016_dcfc, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1016_dcff, 1); inc(ebx);                               /* inc ebx */
            ii(0x1016_dd00, 2); add(ebp, eax);                          /* add ebp, eax */
            ii(0x1016_dd02, 2); add(edi, eax);                          /* add edi, eax */
            ii(0x1016_dd04, 5); mov(eax, memd_a32[ds, 0x1020_853c]);    /* mov eax, [0x1020853c] */
            ii(0x1016_dd09, 6); mov(memd_a32[ds, 0x1020_8560], ebp);    /* mov [0x10208560], ebp */
            ii(0x1016_dd0f, 6); mov(memd_a32[ds, 0x1020_888c], edi);    /* mov [0x1020888c], edi */
            ii(0x1016_dd15, 6); mov(ebp, memd_a32[ds, 0x1020_8570]);    /* mov ebp, [0x10208570] */
            ii(0x1016_dd1b, 6); mov(edi, memd_a32[ds, 0x1020_8888]);    /* mov edi, [0x10208888] */
            ii(0x1016_dd21, 2); add(ebp, eax);                          /* add ebp, eax */
            ii(0x1016_dd23, 2); add(edi, eax);                          /* add edi, eax */
            ii(0x1016_dd25, 6); mov(memd_a32[ds, 0x1020_8570], ebp);    /* mov [0x10208570], ebp */
            ii(0x1016_dd2b, 6); mov(memd_a32[ds, 0x1020_8888], edi);    /* mov [0x10208888], edi */
            ii(0x1016_dd31, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_dd33, 6); mov(ebp, memd_a32[ds, 0x1020_8574]);    /* mov ebp, [0x10208574] */
            ii(0x1016_dd39, 6); mov(edi, memd_a32[ds, 0x1020_8890]);    /* mov edi, [0x10208890] */
            ii(0x1016_dd3f, 2); add(ebp, ecx);                          /* add ebp, ecx */
            ii(0x1016_dd41, 2); add(edi, ecx);                          /* add edi, ecx */
            ii(0x1016_dd43, 6); mov(memd_a32[ds, 0x1020_8574], ebp);    /* mov [0x10208574], ebp */
            ii(0x1016_dd49, 6); mov(memd_a32[ds, 0x1020_8890], edi);    /* mov [0x10208890], edi */
            ii(0x1016_dd4f, 2); add(ecx, esi);                          /* add ecx, esi */
            ii(0x1016_dd51, 6); mov(ebp, memd_a32[ds, 0x1020_889c]);    /* mov ebp, [0x1020889c] */
            ii(0x1016_dd57, 6); mov(memd_a32[ds, 0x1020_8894], ecx);    /* mov [0x10208894], ecx */
            ii(0x1016_dd5d, 2); cmp(ebx, ebp);                          /* cmp ebx, ebp */
            ii(0x1016_dd5f, 6); if(jled(0x1016_dc95, -0xd0)) goto l_0x1016_dc95; /* jle 0x1016dc95 */
        l_0x1016_dd65:
            ii(0x1016_dd65, 6); mov(ebx, memd_a32[ds, 0x1020_88a4]);    /* mov ebx, [0x102088a4] */
            ii(0x1016_dd6b, 6); mov(ecx, memd_a32[ds, 0x1020_8898]);    /* mov ecx, [0x10208898] */
            ii(0x1016_dd71, 5); mov(eax, memd_a32[ds, 0x1020_856c]);    /* mov eax, [0x1020856c] */
            ii(0x1016_dd76, 2); sub(ecx, esi);                          /* sub ecx, esi */
            ii(0x1016_dd78, 6); mov(edi, memd_a32[ds, 0x1020_853c]);    /* mov edi, [0x1020853c] */
            ii(0x1016_dd7e, 2); sub(eax, ecx);                          /* sub eax, ecx */
            ii(0x1016_dd80, 3); shl(edi, 0x2);                          /* shl edi, 0x2 */
            ii(0x1016_dd83, 5); mov(memd_a32[ds, 0x1020_8574], eax);    /* mov [0x10208574], eax */
            ii(0x1016_dd88, 5); mov(memd_a32[ds, 0x1020_8890], eax);    /* mov [0x10208890], eax */
            ii(0x1016_dd8d, 5); mov(eax, memd_a32[ds, 0x1020_8550]);    /* mov eax, [0x10208550] */
            ii(0x1016_dd92, 6); mov(ebp, memd_a32[ds, 0x1020_88a0]);    /* mov ebp, [0x102088a0] */
            ii(0x1016_dd98, 2); sub(eax, edi);                          /* sub eax, edi */
            ii(0x1016_dd9a, 6); mov(edi, memd_a32[ds, 0x1020_853c]);    /* mov edi, [0x1020853c] */
            ii(0x1016_dda0, 5); mov(memd_a32[ds, 0x1020_8560], eax);    /* mov [0x10208560], eax */
            ii(0x1016_dda5, 5); mov(memd_a32[ds, 0x1020_888c], eax);    /* mov [0x1020888c], eax */
            ii(0x1016_ddaa, 5); mov(eax, memd_a32[ds, 0x1020_8538]);    /* mov eax, [0x10208538] */
            ii(0x1016_ddaf, 1); dec(ebx);                               /* dec ebx */
            ii(0x1016_ddb0, 2); sub(eax, edi);                          /* sub eax, edi */
            ii(0x1016_ddb2, 6); mov(memd_a32[ds, 0x1020_8894], ecx);    /* mov [0x10208894], ecx */
            ii(0x1016_ddb8, 5); mov(memd_a32[ds, 0x1020_8570], eax);    /* mov [0x10208570], eax */
            ii(0x1016_ddbd, 5); mov(memd_a32[ds, 0x1020_8888], eax);    /* mov [0x10208888], eax */
            ii(0x1016_ddc2, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1016_ddc7, 2); cmp(ebx, ebp);                          /* cmp ebx, ebp */
            ii(0x1016_ddc9, 6); if(jld(0x1016_de9d, 0xce)) goto l_0x1016_de9d; /* jl 0x1016de9d */
        l_0x1016_ddcf:
            ii(0x1016_ddcf, 5); calld(/* sys */ 0x1016_deac, 0xd8);     /* call 0x1016deac */
            ii(0x1016_ddd4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_ddd6, 2); if(jzd(0x1016_de13, 0x3b)) goto l_0x1016_de13; /* jz 0x1016de13 */
            ii(0x1016_ddd8, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1016_ddda, 2); if(jnzd(0x1016_de1b, 0x3f)) goto l_0x1016_de1b; /* jnz 0x1016de1b */
            ii(0x1016_dddc, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1016_dde1, 5); mov(eax, memd_a32[ds, 0x1020_888c]);    /* mov eax, [0x1020888c] */
            ii(0x1016_dde6, 6); mov(ecx, memd_a32[ds, 0x1020_8894]);    /* mov ecx, [0x10208894] */
            ii(0x1016_ddec, 5); mov(memd_a32[ds, 0x1020_8550], eax);    /* mov [0x10208550], eax */
            ii(0x1016_ddf1, 5); mov(eax, memd_a32[ds, 0x1020_8888]);    /* mov eax, [0x10208888] */
            ii(0x1016_ddf6, 6); mov(memd_a32[ds, 0x1020_88a4], ebx);    /* mov [0x102088a4], ebx */
            ii(0x1016_ddfc, 5); mov(memd_a32[ds, 0x1020_8538], eax);    /* mov [0x10208538], eax */
            ii(0x1016_de01, 5); mov(eax, memd_a32[ds, 0x1020_8890]);    /* mov eax, [0x10208890] */
            ii(0x1016_de06, 6); mov(memd_a32[ds, 0x1020_8898], ecx);    /* mov [0x10208898], ecx */
            ii(0x1016_de0c, 5); mov(memd_a32[ds, 0x1020_856c], eax);    /* mov [0x1020856c], eax */
            ii(0x1016_de11, 2); jmpd(0x1016_de1b, 0x8); goto l_0x1016_de1b; /* jmp 0x1016de1b */
        l_0x1016_de13:
            ii(0x1016_de13, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1016_de15, 6); if(jnzd(0x1016_de9d, 0x82)) goto l_0x1016_de9d; /* jnz 0x1016de9d */
        l_0x1016_de1b:
            ii(0x1016_de1b, 5); mov(eax, memd_a32[ds, 0x1020_853c]);    /* mov eax, [0x1020853c] */
            ii(0x1016_de20, 6); mov(ecx, memd_a32[ds, 0x1020_8560]);    /* mov ecx, [0x10208560] */
            ii(0x1016_de26, 6); mov(edi, memd_a32[ds, 0x1020_888c]);    /* mov edi, [0x1020888c] */
            ii(0x1016_de2c, 6); mov(ebp, memd_a32[ds, 0x1020_8570]);    /* mov ebp, [0x10208570] */
            ii(0x1016_de32, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1016_de35, 1); dec(ebx);                               /* dec ebx */
            ii(0x1016_de36, 2); sub(ecx, eax);                          /* sub ecx, eax */
            ii(0x1016_de38, 2); sub(edi, eax);                          /* sub edi, eax */
            ii(0x1016_de3a, 5); mov(eax, memd_a32[ds, 0x1020_853c]);    /* mov eax, [0x1020853c] */
            ii(0x1016_de3f, 6); mov(memd_a32[ds, 0x1020_8560], ecx);    /* mov [0x10208560], ecx */
            ii(0x1016_de45, 6); mov(memd_a32[ds, 0x1020_888c], edi);    /* mov [0x1020888c], edi */
            ii(0x1016_de4b, 6); mov(ecx, memd_a32[ds, 0x1020_8888]);    /* mov ecx, [0x10208888] */
            ii(0x1016_de51, 6); mov(edi, memd_a32[ds, 0x1020_8574]);    /* mov edi, [0x10208574] */
            ii(0x1016_de57, 2); sub(ecx, eax);                          /* sub ecx, eax */
            ii(0x1016_de59, 2); sub(ebp, eax);                          /* sub ebp, eax */
            ii(0x1016_de5b, 6); mov(memd_a32[ds, 0x1020_8888], ecx);    /* mov [0x10208888], ecx */
            ii(0x1016_de61, 6); mov(ecx, memd_a32[ds, 0x1020_8894]);    /* mov ecx, [0x10208894] */
            ii(0x1016_de67, 6); mov(memd_a32[ds, 0x1020_8570], ebp);    /* mov [0x10208570], ebp */
            ii(0x1016_de6d, 2); sub(ecx, esi);                          /* sub ecx, esi */
            ii(0x1016_de6f, 6); mov(ebp, memd_a32[ds, 0x1020_8890]);    /* mov ebp, [0x10208890] */
            ii(0x1016_de75, 6); mov(memd_a32[ds, 0x1020_8894], ecx);    /* mov [0x10208894], ecx */
            ii(0x1016_de7b, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1016_de7d, 2); sub(edi, ecx);                          /* sub edi, ecx */
            ii(0x1016_de7f, 2); sub(ebp, ecx);                          /* sub ebp, ecx */
            ii(0x1016_de81, 6); mov(memd_a32[ds, 0x1020_8574], edi);    /* mov [0x10208574], edi */
            ii(0x1016_de87, 6); mov(memd_a32[ds, 0x1020_8890], ebp);    /* mov [0x10208890], ebp */
            ii(0x1016_de8d, 6); mov(edi, memd_a32[ds, 0x1020_88a0]);    /* mov edi, [0x102088a0] */
            ii(0x1016_de93, 2); xor(eax, ecx);                          /* xor eax, ecx */
            ii(0x1016_de95, 2); cmp(ebx, edi);                          /* cmp ebx, edi */
            ii(0x1016_de97, 6); if(jged(0x1016_ddcf, -0xce)) goto l_0x1016_ddcf; /* jge 0x1016ddcf */
        l_0x1016_de9d:
            ii(0x1016_de9d, 6); mov(ecx, memd_a32[ds, 0x1020_8894]);    /* mov ecx, [0x10208894] */
            ii(0x1016_dea3, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_dea5, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_dea6, 1); popd(edi);                              /* pop edi */
            ii(0x1016_dea7, 1); popd(esi);                              /* pop esi */
            ii(0x1016_dea8, 1); popd(edx);                              /* pop edx */
            ii(0x1016_dea9, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_deaa, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_deab, 1); retd(); return;                         /* ret */
        }
    }
}
