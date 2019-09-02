using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_dd71-443ff8c0")]
        public void Method_1012_dd71()
        {
            ii(0x1012_dd71, 5); push(0xac);                             /* push 0xac */
            ii(0x1012_dd76, 5); call(Definitions.sys_check_available_stack_size, 0x3_7fd7); /* call 0x10165d52 */
            ii(0x1012_dd7b, 1); push(ebx);                              /* push ebx */
            ii(0x1012_dd7c, 1); push(ecx);                              /* push ecx */
            ii(0x1012_dd7d, 1); push(esi);                              /* push esi */
            ii(0x1012_dd7e, 1); push(edi);                              /* push edi */
            ii(0x1012_dd7f, 1); push(ebp);                              /* push ebp */
            ii(0x1012_dd80, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_dd82, 6); sub(esp, 0x94);                         /* sub esp, 0x94 */
            ii(0x1012_dd88, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1012_dd8b, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1012_dd8e, 7); test(memd[ss, ebp - 4], 4);             /* test dword [ebp-0x4], 0x4 */
            ii(0x1012_dd95, 2); if(jz(0x1012_ddae, 0x17)) goto l_0x1012_ddae; /* jz 0x1012ddae */
            ii(0x1012_dd97, 5); mov(edx, 0x101b_6bc0);                  /* mov edx, 0x101b6bc0 */
            ii(0x1012_dd9c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_dd9f, 5); call(Definitions.sys_call_dtor_arr, 0x3_8214); /* call 0x10165fb8 */
            ii(0x1012_dda4, 5); call(Definitions.sys_delete_arr, 0x3_822f); /* call 0x10165fd8 */
            ii(0x1012_dda9, 5); jmp(0x1012_e14f, 0x3a1); goto l_0x1012_e14f; /* jmp 0x1012e14f */
        l_0x1012_ddae:
            ii(0x1012_ddae, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_ddb1, 7); mov(memd[ds, eax + 19], 0x101b_6bd8);   /* mov dword [eax+0x13], 0x101b6bd8 */
            ii(0x1012_ddb8, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_ddbb, 6); mov(eax, memd[ds, eax + 222]);          /* mov eax, [eax+0xde] */
            ii(0x1012_ddc1, 6); mov(memd[ss, ebp - 148], eax);          /* mov [ebp-0x94], eax */
            ii(0x1012_ddc7, 7); cmp(memd[ss, ebp - 148], 0);            /* cmp dword [ebp-0x94], 0x0 */
            ii(0x1012_ddce, 2); if(jz(0x1012_dde7, 0x17)) goto l_0x1012_dde7; /* jz 0x1012dde7 */
            ii(0x1012_ddd0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_ddd2, 6); mov(eax, memd[ss, ebp - 148]);          /* mov eax, [ebp-0x94] */
            ii(0x1012_ddd8, 5); call(Definitions.my_dtor_d3, -0x5_60aa); /* call 0x100d7d33 */
            ii(0x1012_dddd, 5); call(Definitions.sys_delete, 0x3_8182); /* call 0x10165f64 */
            ii(0x1012_dde2, 3); mov(memd[ss, ebp - 80], eax);           /* mov [ebp-0x50], eax */
            ii(0x1012_dde5, 2); jmp(0x1012_ddee, 7); goto l_0x1012_ddee; /* jmp 0x1012ddee */
        l_0x1012_dde7:
            ii(0x1012_dde7, 7); mov(memd[ss, ebp - 80], 0);             /* mov dword [ebp-0x50], 0x0 */
        l_0x1012_ddee:
            ii(0x1012_ddee, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_ddf1, 6); mov(eax, memd[ds, eax + 158]);          /* mov eax, [eax+0x9e] */
            ii(0x1012_ddf7, 6); mov(memd[ss, ebp - 144], eax);          /* mov [ebp-0x90], eax */
            ii(0x1012_ddfd, 7); cmp(memd[ss, ebp - 144], 0);            /* cmp dword [ebp-0x90], 0x0 */
            ii(0x1012_de04, 2); if(jz(0x1012_de1d, 0x17)) goto l_0x1012_de1d; /* jz 0x1012de1d */
            ii(0x1012_de06, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_de08, 6); mov(eax, memd[ss, ebp - 144]);          /* mov eax, [ebp-0x90] */
            ii(0x1012_de0e, 5); call(Definitions.my_dtor_d2, -0x5_f8db); /* call 0x100ce538 */
            ii(0x1012_de13, 5); call(Definitions.sys_delete, 0x3_814c); /* call 0x10165f64 */
            ii(0x1012_de18, 3); mov(memd[ss, ebp - 76], eax);           /* mov [ebp-0x4c], eax */
            ii(0x1012_de1b, 2); jmp(0x1012_de24, 7); goto l_0x1012_de24; /* jmp 0x1012de24 */
        l_0x1012_de1d:
            ii(0x1012_de1d, 7); mov(memd[ss, ebp - 76], 0);             /* mov dword [ebp-0x4c], 0x0 */
        l_0x1012_de24:
            ii(0x1012_de24, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_de27, 6); mov(eax, memd[ds, eax + 162]);          /* mov eax, [eax+0xa2] */
            ii(0x1012_de2d, 6); mov(memd[ss, ebp - 140], eax);          /* mov [ebp-0x8c], eax */
            ii(0x1012_de33, 7); cmp(memd[ss, ebp - 140], 0);            /* cmp dword [ebp-0x8c], 0x0 */
            ii(0x1012_de3a, 2); if(jz(0x1012_de53, 0x17)) goto l_0x1012_de53; /* jz 0x1012de53 */
            ii(0x1012_de3c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_de3e, 6); mov(eax, memd[ss, ebp - 140]);          /* mov eax, [ebp-0x8c] */
            ii(0x1012_de44, 5); call(Definitions.my_dtor_d2, -0x5_f911); /* call 0x100ce538 */
            ii(0x1012_de49, 5); call(Definitions.sys_delete, 0x3_8116); /* call 0x10165f64 */
            ii(0x1012_de4e, 3); mov(memd[ss, ebp - 72], eax);           /* mov [ebp-0x48], eax */
            ii(0x1012_de51, 2); jmp(0x1012_de5a, 7); goto l_0x1012_de5a; /* jmp 0x1012de5a */
        l_0x1012_de53:
            ii(0x1012_de53, 7); mov(memd[ss, ebp - 72], 0);             /* mov dword [ebp-0x48], 0x0 */
        l_0x1012_de5a:
            ii(0x1012_de5a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_de5d, 6); mov(eax, memd[ds, eax + 166]);          /* mov eax, [eax+0xa6] */
            ii(0x1012_de63, 6); mov(memd[ss, ebp - 136], eax);          /* mov [ebp-0x88], eax */
            ii(0x1012_de69, 7); cmp(memd[ss, ebp - 136], 0);            /* cmp dword [ebp-0x88], 0x0 */
            ii(0x1012_de70, 2); if(jz(0x1012_de89, 0x17)) goto l_0x1012_de89; /* jz 0x1012de89 */
            ii(0x1012_de72, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_de74, 6); mov(eax, memd[ss, ebp - 136]);          /* mov eax, [ebp-0x88] */
            ii(0x1012_de7a, 5); call(Definitions.my_dtor_d2, -0x5_f947); /* call 0x100ce538 */
            ii(0x1012_de7f, 5); call(Definitions.sys_delete, 0x3_80e0); /* call 0x10165f64 */
            ii(0x1012_de84, 3); mov(memd[ss, ebp - 68], eax);           /* mov [ebp-0x44], eax */
            ii(0x1012_de87, 2); jmp(0x1012_de90, 7); goto l_0x1012_de90; /* jmp 0x1012de90 */
        l_0x1012_de89:
            ii(0x1012_de89, 7); mov(memd[ss, ebp - 68], 0);             /* mov dword [ebp-0x44], 0x0 */
        l_0x1012_de90:
            ii(0x1012_de90, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_de93, 6); mov(eax, memd[ds, eax + 170]);          /* mov eax, [eax+0xaa] */
            ii(0x1012_de99, 6); mov(memd[ss, ebp - 132], eax);          /* mov [ebp-0x84], eax */
            ii(0x1012_de9f, 7); cmp(memd[ss, ebp - 132], 0);            /* cmp dword [ebp-0x84], 0x0 */
            ii(0x1012_dea6, 2); if(jz(0x1012_debf, 0x17)) goto l_0x1012_debf; /* jz 0x1012debf */
            ii(0x1012_dea8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_deaa, 6); mov(eax, memd[ss, ebp - 132]);          /* mov eax, [ebp-0x84] */
            ii(0x1012_deb0, 5); call(Definitions.my_dtor_d2, -0x5_f97d); /* call 0x100ce538 */
            ii(0x1012_deb5, 5); call(Definitions.sys_delete, 0x3_80aa); /* call 0x10165f64 */
            ii(0x1012_deba, 3); mov(memd[ss, ebp - 64], eax);           /* mov [ebp-0x40], eax */
            ii(0x1012_debd, 2); jmp(0x1012_dec6, 7); goto l_0x1012_dec6; /* jmp 0x1012dec6 */
        l_0x1012_debf:
            ii(0x1012_debf, 7); mov(memd[ss, ebp - 64], 0);             /* mov dword [ebp-0x40], 0x0 */
        l_0x1012_dec6:
            ii(0x1012_dec6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_dec9, 6); mov(eax, memd[ds, eax + 174]);          /* mov eax, [eax+0xae] */
            ii(0x1012_decf, 3); mov(memd[ss, ebp - 128], eax);          /* mov [ebp-0x80], eax */
            ii(0x1012_ded2, 4); cmp(memd[ss, ebp - 128], 0);            /* cmp dword [ebp-0x80], 0x0 */
            ii(0x1012_ded6, 2); if(jz(0x1012_deec, 0x14)) goto l_0x1012_deec; /* jz 0x1012deec */
            ii(0x1012_ded8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_deda, 3); mov(eax, memd[ss, ebp - 128]);          /* mov eax, [ebp-0x80] */
            ii(0x1012_dedd, 5); call(Definitions.my_dtor_d2, -0x5_f9aa); /* call 0x100ce538 */
            ii(0x1012_dee2, 5); call(Definitions.sys_delete, 0x3_807d); /* call 0x10165f64 */
            ii(0x1012_dee7, 3); mov(memd[ss, ebp - 60], eax);           /* mov [ebp-0x3c], eax */
            ii(0x1012_deea, 2); jmp(0x1012_def3, 7); goto l_0x1012_def3; /* jmp 0x1012def3 */
        l_0x1012_deec:
            ii(0x1012_deec, 7); mov(memd[ss, ebp - 60], 0);             /* mov dword [ebp-0x3c], 0x0 */
        l_0x1012_def3:
            ii(0x1012_def3, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_def6, 6); mov(eax, memd[ds, eax + 178]);          /* mov eax, [eax+0xb2] */
            ii(0x1012_defc, 3); mov(memd[ss, ebp - 124], eax);          /* mov [ebp-0x7c], eax */
            ii(0x1012_deff, 4); cmp(memd[ss, ebp - 124], 0);            /* cmp dword [ebp-0x7c], 0x0 */
            ii(0x1012_df03, 2); if(jz(0x1012_df19, 0x14)) goto l_0x1012_df19; /* jz 0x1012df19 */
            ii(0x1012_df05, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_df07, 3); mov(eax, memd[ss, ebp - 124]);          /* mov eax, [ebp-0x7c] */
            ii(0x1012_df0a, 5); call(Definitions.my_dtor_d2, -0x5_f9d7); /* call 0x100ce538 */
            ii(0x1012_df0f, 5); call(Definitions.sys_delete, 0x3_8050); /* call 0x10165f64 */
            ii(0x1012_df14, 3); mov(memd[ss, ebp - 56], eax);           /* mov [ebp-0x38], eax */
            ii(0x1012_df17, 2); jmp(0x1012_df20, 7); goto l_0x1012_df20; /* jmp 0x1012df20 */
        l_0x1012_df19:
            ii(0x1012_df19, 7); mov(memd[ss, ebp - 56], 0);             /* mov dword [ebp-0x38], 0x0 */
        l_0x1012_df20:
            ii(0x1012_df20, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_df23, 6); mov(eax, memd[ds, eax + 182]);          /* mov eax, [eax+0xb6] */
            ii(0x1012_df29, 3); mov(memd[ss, ebp - 120], eax);          /* mov [ebp-0x78], eax */
            ii(0x1012_df2c, 4); cmp(memd[ss, ebp - 120], 0);            /* cmp dword [ebp-0x78], 0x0 */
            ii(0x1012_df30, 2); if(jz(0x1012_df46, 0x14)) goto l_0x1012_df46; /* jz 0x1012df46 */
            ii(0x1012_df32, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_df34, 3); mov(eax, memd[ss, ebp - 120]);          /* mov eax, [ebp-0x78] */
            ii(0x1012_df37, 5); call(Definitions.my_dtor_d2, -0x5_fa04); /* call 0x100ce538 */
            ii(0x1012_df3c, 5); call(Definitions.sys_delete, 0x3_8023); /* call 0x10165f64 */
            ii(0x1012_df41, 3); mov(memd[ss, ebp - 52], eax);           /* mov [ebp-0x34], eax */
            ii(0x1012_df44, 2); jmp(0x1012_df4d, 7); goto l_0x1012_df4d; /* jmp 0x1012df4d */
        l_0x1012_df46:
            ii(0x1012_df46, 7); mov(memd[ss, ebp - 52], 0);             /* mov dword [ebp-0x34], 0x0 */
        l_0x1012_df4d:
            ii(0x1012_df4d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_df50, 6); mov(eax, memd[ds, eax + 186]);          /* mov eax, [eax+0xba] */
            ii(0x1012_df56, 3); mov(memd[ss, ebp - 116], eax);          /* mov [ebp-0x74], eax */
            ii(0x1012_df59, 4); cmp(memd[ss, ebp - 116], 0);            /* cmp dword [ebp-0x74], 0x0 */
            ii(0x1012_df5d, 2); if(jz(0x1012_df73, 0x14)) goto l_0x1012_df73; /* jz 0x1012df73 */
            ii(0x1012_df5f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_df61, 3); mov(eax, memd[ss, ebp - 116]);          /* mov eax, [ebp-0x74] */
            ii(0x1012_df64, 5); call(Definitions.my_dtor_d2, -0x5_fa31); /* call 0x100ce538 */
            ii(0x1012_df69, 5); call(Definitions.sys_delete, 0x3_7ff6); /* call 0x10165f64 */
            ii(0x1012_df6e, 3); mov(memd[ss, ebp - 48], eax);           /* mov [ebp-0x30], eax */
            ii(0x1012_df71, 2); jmp(0x1012_df7a, 7); goto l_0x1012_df7a; /* jmp 0x1012df7a */
        l_0x1012_df73:
            ii(0x1012_df73, 7); mov(memd[ss, ebp - 48], 0);             /* mov dword [ebp-0x30], 0x0 */
        l_0x1012_df7a:
            ii(0x1012_df7a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_df7d, 6); mov(eax, memd[ds, eax + 190]);          /* mov eax, [eax+0xbe] */
            ii(0x1012_df83, 3); mov(memd[ss, ebp - 112], eax);          /* mov [ebp-0x70], eax */
            ii(0x1012_df86, 4); cmp(memd[ss, ebp - 112], 0);            /* cmp dword [ebp-0x70], 0x0 */
            ii(0x1012_df8a, 2); if(jz(0x1012_dfa0, 0x14)) goto l_0x1012_dfa0; /* jz 0x1012dfa0 */
            ii(0x1012_df8c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_df8e, 3); mov(eax, memd[ss, ebp - 112]);          /* mov eax, [ebp-0x70] */
            ii(0x1012_df91, 5); call(Definitions.my_dtor_d2, -0x5_fa5e); /* call 0x100ce538 */
            ii(0x1012_df96, 5); call(Definitions.sys_delete, 0x3_7fc9); /* call 0x10165f64 */
            ii(0x1012_df9b, 3); mov(memd[ss, ebp - 44], eax);           /* mov [ebp-0x2c], eax */
            ii(0x1012_df9e, 2); jmp(0x1012_dfa7, 7); goto l_0x1012_dfa7; /* jmp 0x1012dfa7 */
        l_0x1012_dfa0:
            ii(0x1012_dfa0, 7); mov(memd[ss, ebp - 44], 0);             /* mov dword [ebp-0x2c], 0x0 */
        l_0x1012_dfa7:
            ii(0x1012_dfa7, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_dfaa, 6); mov(eax, memd[ds, eax + 194]);          /* mov eax, [eax+0xc2] */
            ii(0x1012_dfb0, 3); mov(memd[ss, ebp - 108], eax);          /* mov [ebp-0x6c], eax */
            ii(0x1012_dfb3, 4); cmp(memd[ss, ebp - 108], 0);            /* cmp dword [ebp-0x6c], 0x0 */
            ii(0x1012_dfb7, 2); if(jz(0x1012_dfcd, 0x14)) goto l_0x1012_dfcd; /* jz 0x1012dfcd */
            ii(0x1012_dfb9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_dfbb, 3); mov(eax, memd[ss, ebp - 108]);          /* mov eax, [ebp-0x6c] */
            ii(0x1012_dfbe, 5); call(Definitions.my_dtor_d2, -0x5_fa8b); /* call 0x100ce538 */
            ii(0x1012_dfc3, 5); call(Definitions.sys_delete, 0x3_7f9c); /* call 0x10165f64 */
            ii(0x1012_dfc8, 3); mov(memd[ss, ebp - 40], eax);           /* mov [ebp-0x28], eax */
            ii(0x1012_dfcb, 2); jmp(0x1012_dfd4, 7); goto l_0x1012_dfd4; /* jmp 0x1012dfd4 */
        l_0x1012_dfcd:
            ii(0x1012_dfcd, 7); mov(memd[ss, ebp - 40], 0);             /* mov dword [ebp-0x28], 0x0 */
        l_0x1012_dfd4:
            ii(0x1012_dfd4, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_dfd7, 6); mov(eax, memd[ds, eax + 198]);          /* mov eax, [eax+0xc6] */
            ii(0x1012_dfdd, 3); mov(memd[ss, ebp - 104], eax);          /* mov [ebp-0x68], eax */
            ii(0x1012_dfe0, 4); cmp(memd[ss, ebp - 104], 0);            /* cmp dword [ebp-0x68], 0x0 */
            ii(0x1012_dfe4, 2); if(jz(0x1012_dffa, 0x14)) goto l_0x1012_dffa; /* jz 0x1012dffa */
            ii(0x1012_dfe6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_dfe8, 3); mov(eax, memd[ss, ebp - 104]);          /* mov eax, [ebp-0x68] */
            ii(0x1012_dfeb, 5); call(Definitions.my_dtor_d2, -0x5_fab8); /* call 0x100ce538 */
            ii(0x1012_dff0, 5); call(Definitions.sys_delete, 0x3_7f6f); /* call 0x10165f64 */
            ii(0x1012_dff5, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
            ii(0x1012_dff8, 2); jmp(0x1012_e001, 7); goto l_0x1012_e001; /* jmp 0x1012e001 */
        l_0x1012_dffa:
            ii(0x1012_dffa, 7); mov(memd[ss, ebp - 36], 0);             /* mov dword [ebp-0x24], 0x0 */
        l_0x1012_e001:
            ii(0x1012_e001, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_e004, 6); mov(eax, memd[ds, eax + 202]);          /* mov eax, [eax+0xca] */
            ii(0x1012_e00a, 3); mov(memd[ss, ebp - 100], eax);          /* mov [ebp-0x64], eax */
            ii(0x1012_e00d, 4); cmp(memd[ss, ebp - 100], 0);            /* cmp dword [ebp-0x64], 0x0 */
            ii(0x1012_e011, 2); if(jz(0x1012_e027, 0x14)) goto l_0x1012_e027; /* jz 0x1012e027 */
            ii(0x1012_e013, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_e015, 3); mov(eax, memd[ss, ebp - 100]);          /* mov eax, [ebp-0x64] */
            ii(0x1012_e018, 5); call(Definitions.my_dtor_d2, -0x5_fae5); /* call 0x100ce538 */
            ii(0x1012_e01d, 5); call(Definitions.sys_delete, 0x3_7f42); /* call 0x10165f64 */
            ii(0x1012_e022, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x1012_e025, 2); jmp(0x1012_e02e, 7); goto l_0x1012_e02e; /* jmp 0x1012e02e */
        l_0x1012_e027:
            ii(0x1012_e027, 7); mov(memd[ss, ebp - 32], 0);             /* mov dword [ebp-0x20], 0x0 */
        l_0x1012_e02e:
            ii(0x1012_e02e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_e031, 6); mov(eax, memd[ds, eax + 206]);          /* mov eax, [eax+0xce] */
            ii(0x1012_e037, 3); mov(memd[ss, ebp - 96], eax);           /* mov [ebp-0x60], eax */
            ii(0x1012_e03a, 4); cmp(memd[ss, ebp - 96], 0);             /* cmp dword [ebp-0x60], 0x0 */
            ii(0x1012_e03e, 2); if(jz(0x1012_e054, 0x14)) goto l_0x1012_e054; /* jz 0x1012e054 */
            ii(0x1012_e040, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_e042, 3); mov(eax, memd[ss, ebp - 96]);           /* mov eax, [ebp-0x60] */
            ii(0x1012_e045, 5); call(Definitions.my_dtor_d2, -0x5_fb12); /* call 0x100ce538 */
            ii(0x1012_e04a, 5); call(Definitions.sys_delete, 0x3_7f15); /* call 0x10165f64 */
            ii(0x1012_e04f, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x1012_e052, 2); jmp(0x1012_e05b, 7); goto l_0x1012_e05b; /* jmp 0x1012e05b */
        l_0x1012_e054:
            ii(0x1012_e054, 7); mov(memd[ss, ebp - 28], 0);             /* mov dword [ebp-0x1c], 0x0 */
        l_0x1012_e05b:
            ii(0x1012_e05b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_e05e, 6); mov(eax, memd[ds, eax + 210]);          /* mov eax, [eax+0xd2] */
            ii(0x1012_e064, 3); mov(memd[ss, ebp - 92], eax);           /* mov [ebp-0x5c], eax */
            ii(0x1012_e067, 4); cmp(memd[ss, ebp - 92], 0);             /* cmp dword [ebp-0x5c], 0x0 */
            ii(0x1012_e06b, 2); if(jz(0x1012_e081, 0x14)) goto l_0x1012_e081; /* jz 0x1012e081 */
            ii(0x1012_e06d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_e06f, 3); mov(eax, memd[ss, ebp - 92]);           /* mov eax, [ebp-0x5c] */
            ii(0x1012_e072, 5); call(Definitions.my_dtor_d2, -0x5_fb3f); /* call 0x100ce538 */
            ii(0x1012_e077, 5); call(Definitions.sys_delete, 0x3_7ee8); /* call 0x10165f64 */
            ii(0x1012_e07c, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1012_e07f, 2); jmp(0x1012_e088, 7); goto l_0x1012_e088; /* jmp 0x1012e088 */
        l_0x1012_e081:
            ii(0x1012_e081, 7); mov(memd[ss, ebp - 24], 0);             /* mov dword [ebp-0x18], 0x0 */
        l_0x1012_e088:
            ii(0x1012_e088, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_e08b, 6); mov(eax, memd[ds, eax + 214]);          /* mov eax, [eax+0xd6] */
            ii(0x1012_e091, 3); mov(memd[ss, ebp - 88], eax);           /* mov [ebp-0x58], eax */
            ii(0x1012_e094, 4); cmp(memd[ss, ebp - 88], 0);             /* cmp dword [ebp-0x58], 0x0 */
            ii(0x1012_e098, 2); if(jz(0x1012_e0ae, 0x14)) goto l_0x1012_e0ae; /* jz 0x1012e0ae */
            ii(0x1012_e09a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_e09c, 3); mov(eax, memd[ss, ebp - 88]);           /* mov eax, [ebp-0x58] */
            ii(0x1012_e09f, 5); call(Definitions.my_dtor_d2, -0x5_fb6c); /* call 0x100ce538 */
            ii(0x1012_e0a4, 5); call(Definitions.sys_delete, 0x3_7ebb); /* call 0x10165f64 */
            ii(0x1012_e0a9, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1012_e0ac, 2); jmp(0x1012_e0b5, 7); goto l_0x1012_e0b5; /* jmp 0x1012e0b5 */
        l_0x1012_e0ae:
            ii(0x1012_e0ae, 7); mov(memd[ss, ebp - 20], 0);             /* mov dword [ebp-0x14], 0x0 */
        l_0x1012_e0b5:
            ii(0x1012_e0b5, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_e0b8, 6); mov(eax, memd[ds, eax + 218]);          /* mov eax, [eax+0xda] */
            ii(0x1012_e0be, 3); mov(memd[ss, ebp - 84], eax);           /* mov [ebp-0x54], eax */
            ii(0x1012_e0c1, 4); cmp(memd[ss, ebp - 84], 0);             /* cmp dword [ebp-0x54], 0x0 */
            ii(0x1012_e0c5, 2); if(jz(0x1012_e0db, 0x14)) goto l_0x1012_e0db; /* jz 0x1012e0db */
            ii(0x1012_e0c7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_e0c9, 3); mov(eax, memd[ss, ebp - 84]);           /* mov eax, [ebp-0x54] */
            ii(0x1012_e0cc, 5); call(Definitions.my_dtor_d2, -0x5_fb99); /* call 0x100ce538 */
            ii(0x1012_e0d1, 5); call(Definitions.sys_delete, 0x3_7e8e); /* call 0x10165f64 */
            ii(0x1012_e0d6, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1012_e0d9, 2); jmp(0x1012_e0e2, 7); goto l_0x1012_e0e2; /* jmp 0x1012e0e2 */
        l_0x1012_e0db:
            ii(0x1012_e0db, 7); mov(memd[ss, ebp - 16], 0);             /* mov dword [ebp-0x10], 0x0 */
        l_0x1012_e0e2:
            ii(0x1012_e0e2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_e0e4, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_e0e7, 3); add(eax, 0x36);                         /* add eax, 0x36 */
            ii(0x1012_e0ea, 5); call(0x1013_17ac, 0x36bd);              /* call 0x101317ac */
            ii(0x1012_e0ef, 3); sub(eax, 0x36);                         /* sub eax, 0x36 */
            ii(0x1012_e0f2, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1012_e0f5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_e0f7, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_e0fa, 3); add(eax, 0x26);                         /* add eax, 0x26 */
            ii(0x1012_e0fd, 5); call(0x1013_1880, 0x377e);              /* call 0x10131880 */
            ii(0x1012_e102, 3); sub(eax, 0x26);                         /* sub eax, 0x26 */
            ii(0x1012_e105, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1012_e108, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_e10a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_e10d, 3); add(eax, 0x22);                         /* add eax, 0x22 */
            ii(0x1012_e110, 5); call(0x1008_8b04, -0xa_5611);           /* call 0x10088b04 */
            ii(0x1012_e115, 3); sub(eax, 0x22);                         /* sub eax, 0x22 */
            ii(0x1012_e118, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1012_e11b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_e11d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_e120, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1012_e123, 5); call(0x100e_8144, -0x4_5fe4);           /* call 0x100e8144 */
            ii(0x1012_e128, 3); sub(eax, 0x18);                         /* sub eax, 0x18 */
            ii(0x1012_e12b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1012_e12e, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1012_e133, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_e136, 5); call(0x100d_6999, -0x5_77a2);           /* call 0x100d6999 */
            ii(0x1012_e13b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1012_e13e, 7); test(memd[ss, ebp - 4], 2);             /* test dword [ebp-0x4], 0x2 */
            ii(0x1012_e145, 2); if(jz(0x1012_e14f, 8)) goto l_0x1012_e14f; /* jz 0x1012e14f */
            ii(0x1012_e147, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_e14a, 5); call(Definitions.sys_delete, 0x3_7e15); /* call 0x10165f64 */
        l_0x1012_e14f:
            ii(0x1012_e14f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_e152, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1012_e155, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1012_e158, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_e15a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_e15b, 1); pop(edi);                               /* pop edi */
            ii(0x1012_e15c, 1); pop(esi);                               /* pop esi */
            ii(0x1012_e15d, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_e15e, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_e15f, 1); ret();                                  /* ret */
        }
    }
}
