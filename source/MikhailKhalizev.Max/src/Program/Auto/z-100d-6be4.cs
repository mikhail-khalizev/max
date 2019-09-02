using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_6be4-81af94dd")]
        public void Method_100d_6be4()
        {
            ii(0x100d_6be4, 5); push(0x68);                             /* push 0x68 */
            ii(0x100d_6be9, 5); call(Definitions.sys_check_available_stack_size, 0x8_f164); /* call 0x10165d52 */
            ii(0x100d_6bee, 1); push(esi);                              /* push esi */
            ii(0x100d_6bef, 1); push(edi);                              /* push edi */
            ii(0x100d_6bf0, 1); push(ebp);                              /* push ebp */
            ii(0x100d_6bf1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_6bf3, 6); sub(esp, 0x54);                         /* sub esp, 0x54 */
            ii(0x100d_6bf9, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_6bfc, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x100d_6bff, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x100d_6c02, 3); mov(memd[ss, ebp - 4], ecx);            /* mov [ebp-0x4], ecx */
            ii(0x100d_6c05, 3); mov(eax, memd[ss, ebp + 0x10]);         /* mov eax, [ebp+0x10] */
            ii(0x100d_6c08, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x100d_6c0b, 4); mov(memw[ds, edx + 0xe], ax);           /* mov [edx+0xe], ax */
            ii(0x100d_6c0f, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x100d_6c12, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x100d_6c15, 3); mov(memd[ds, edx + 0x10], eax);         /* mov [edx+0x10], eax */
            ii(0x100d_6c18, 3); mov(eax, memd[ss, ebp + 0x18]);         /* mov eax, [ebp+0x18] */
            ii(0x100d_6c1b, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x100d_6c1e, 3); mov(memd[ds, edx + 0x14], eax);         /* mov [edx+0x14], eax */
            ii(0x100d_6c21, 3); mov(eax, memd[ss, ebp + 0x1c]);         /* mov eax, [ebp+0x1c] */
            ii(0x100d_6c24, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x100d_6c27, 3); mov(memd[ds, edx + 0x18], eax);         /* mov [edx+0x18], eax */
            ii(0x100d_6c2a, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_6c2d, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x100d_6c30, 3); mov(memd[ds, edx + 0x20], eax);         /* mov [edx+0x20], eax */
            ii(0x100d_6c33, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_6c36, 7); mov(memd[ds, eax + 0x27], 0x101b_5f88); /* mov dword [eax+0x27], 0x101b5f88 */
            ii(0x100d_6c3d, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_6c40, 5); mov(memw[ds, eax], 0);                  /* mov word [eax], 0x0 */
            ii(0x100d_6c45, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_6c48, 6); mov(memw[ds, eax + 2], 0);              /* mov word [eax+0x2], 0x0 */
            ii(0x100d_6c4e, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_6c51, 6); mov(memw[ds, eax + 4], 0);              /* mov word [eax+0x4], 0x0 */
            ii(0x100d_6c57, 3); mov(eax, memd[ss, ebp + 0x20]);         /* mov eax, [ebp+0x20] */
            ii(0x100d_6c5a, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x100d_6c5d, 4); mov(memw[ds, edx + 0x24], ax);          /* mov [edx+0x24], ax */
            ii(0x100d_6c61, 3); mov(al, memb[ss, ebp + 0x24]);          /* mov al, [ebp+0x24] */
            ii(0x100d_6c64, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x100d_6c67, 3); mov(memb[ds, edx + 0x26], al);          /* mov [edx+0x26], al */
            ii(0x100d_6c6a, 5); cmp(memw[ss, ebp + 0x20], 0);           /* cmp word [ebp+0x20], 0x0 */
            ii(0x100d_6c6f, 2); if(jz(0x100d_6cdd, 0x6c)) goto l_0x100d_6cdd; /* jz 0x100d6cdd */
            ii(0x100d_6c71, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100d_6c76, 5); call(Definitions.sys_new, 0x8_f185);    /* call 0x10165e00 */
            ii(0x100d_6c7b, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100d_6c7e, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_6c81, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100d_6c84, 4); cmp(memd[ss, ebp - 0x18], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x100d_6c88, 2); if(jz(0x100d_6ccc, 0x42)) goto l_0x100d_6ccc; /* jz 0x100d6ccc */
            ii(0x100d_6c8a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_6c8d, 4); mov(ax, memw[ds, eax + 0xc]);           /* mov ax, [eax+0xc] */
            ii(0x100d_6c91, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100d_6c94, 4); sub(ax, memw[ds, edx + 4]);             /* sub ax, [edx+0x4] */
            ii(0x100d_6c98, 1); cwde();                                 /* cwde */
            ii(0x100d_6c99, 1); push(eax);                              /* push eax */
            ii(0x100d_6c9a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_6c9d, 4); mov(ax, memw[ds, eax + 8]);             /* mov ax, [eax+0x8] */
            ii(0x100d_6ca1, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100d_6ca4, 3); sub(ax, memw[ds, edx]);                 /* sub ax, [edx] */
            ii(0x100d_6ca7, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100d_6caa, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_6cad, 3); mov(ebx, memd[ds, eax + 2]);            /* mov ebx, [eax+0x2] */
            ii(0x100d_6cb0, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100d_6cb3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_6cb6, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x100d_6cb9, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_6cbc, 5); call(0x100d_7bdc, 0xf1b);               /* call 0x100d7bdc */
            ii(0x100d_6cc1, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100d_6cc4, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100d_6cc7, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x100d_6cca, 2); jmp(0x100d_6cd2, 6); goto l_0x100d_6cd2; /* jmp 0x100d6cd2 */
        l_0x100d_6ccc:
            ii(0x100d_6ccc, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100d_6ccf, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
        l_0x100d_6cd2:
            ii(0x100d_6cd2, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100d_6cd5, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x100d_6cd8, 3); mov(memd[ds, edx + 0xa], eax);          /* mov [edx+0xa], eax */
            ii(0x100d_6cdb, 2); jmp(0x100d_6ce7, 0xa); goto l_0x100d_6ce7; /* jmp 0x100d6ce7 */
        l_0x100d_6cdd:
            ii(0x100d_6cdd, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_6ce0, 7); mov(memd[ds, eax + 0xa], 0);            /* mov dword [eax+0xa], 0x0 */
        l_0x100d_6ce7:
            ii(0x100d_6ce7, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100d_6cec, 5); call(Definitions.sys_new, 0x8_f10f);    /* call 0x10165e00 */
            ii(0x100d_6cf1, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x100d_6cf4, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x100d_6cf7, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x100d_6cfa, 4); cmp(memd[ss, ebp - 0x28], 0);           /* cmp dword [ebp-0x28], 0x0 */
            ii(0x100d_6cfe, 2); if(jz(0x100d_6d42, 0x42)) goto l_0x100d_6d42; /* jz 0x100d6d42 */
            ii(0x100d_6d00, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_6d03, 4); mov(ax, memw[ds, eax + 0xc]);           /* mov ax, [eax+0xc] */
            ii(0x100d_6d07, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_6d0a, 4); sub(ax, memw[ds, edx + 4]);             /* sub ax, [edx+0x4] */
            ii(0x100d_6d0e, 1); cwde();                                 /* cwde */
            ii(0x100d_6d0f, 1); push(eax);                              /* push eax */
            ii(0x100d_6d10, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_6d13, 4); mov(ax, memw[ds, eax + 8]);             /* mov ax, [eax+0x8] */
            ii(0x100d_6d17, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_6d1a, 3); sub(ax, memw[ds, edx]);                 /* sub ax, [edx] */
            ii(0x100d_6d1d, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100d_6d20, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_6d23, 3); mov(ebx, memd[ds, eax + 2]);            /* mov ebx, [eax+0x2] */
            ii(0x100d_6d26, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100d_6d29, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_6d2c, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x100d_6d2f, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x100d_6d32, 5); call(0x100d_7bdc, 0xea5);               /* call 0x100d7bdc */
            ii(0x100d_6d37, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x100d_6d3a, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x100d_6d3d, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x100d_6d40, 2); jmp(0x100d_6d48, 6); goto l_0x100d_6d48; /* jmp 0x100d6d48 */
        l_0x100d_6d42:
            ii(0x100d_6d42, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x100d_6d45, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
        l_0x100d_6d48:
            ii(0x100d_6d48, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100d_6d4b, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x100d_6d4e, 3); mov(memd[ds, edx + 6], eax);            /* mov [edx+0x6], eax */
            ii(0x100d_6d51, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_6d54, 4); cmp(memb[ds, eax + 0x26], 0);           /* cmp byte [eax+0x26], 0x0 */
            ii(0x100d_6d58, 6); if(jz(0x100d_6dd3, 0x75)) goto l_0x100d_6dd3; /* jz 0x100d6dd3 */
            ii(0x100d_6d5e, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_6d63, 5); call(Definitions.sys_new, 0x8_f098);    /* call 0x10165e00 */
            ii(0x100d_6d68, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x100d_6d6b, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x100d_6d6e, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x100d_6d71, 4); cmp(memd[ss, ebp - 0x38], 0);           /* cmp dword [ebp-0x38], 0x0 */
            ii(0x100d_6d75, 2); if(jz(0x100d_6dc2, 0x4b)) goto l_0x100d_6dc2; /* jz 0x100d6dc2 */
            ii(0x100d_6d77, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_6d7a, 4); mov(ax, memw[ds, eax + 0xc]);           /* mov ax, [eax+0xc] */
            ii(0x100d_6d7e, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_6d81, 4); sub(ax, memw[ds, edx + 4]);             /* sub ax, [edx+0x4] */
            ii(0x100d_6d85, 5); add(eax, 6);                            /* add eax, 0x6 */
            ii(0x100d_6d8a, 1); cwde();                                 /* cwde */
            ii(0x100d_6d8b, 1); push(eax);                              /* push eax */
            ii(0x100d_6d8c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_6d8f, 4); mov(ax, memw[ds, eax + 8]);             /* mov ax, [eax+0x8] */
            ii(0x100d_6d93, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_6d96, 3); sub(ax, memw[ds, edx]);                 /* sub ax, [edx] */
            ii(0x100d_6d99, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100d_6d9c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_6d9f, 4); mov(ax, memw[ds, eax + 4]);             /* mov ax, [eax+0x4] */
            ii(0x100d_6da3, 3); sub(eax, 3);                            /* sub eax, 0x3 */
            ii(0x100d_6da6, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100d_6da9, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_6dac, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x100d_6daf, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x100d_6db2, 5); call(0x100c_e39d, -0x8a1a);             /* call 0x100ce39d */
            ii(0x100d_6db7, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
            ii(0x100d_6dba, 3); mov(eax, memd[ss, ebp - 0x3c]);         /* mov eax, [ebp-0x3c] */
            ii(0x100d_6dbd, 3); mov(memd[ss, ebp - 0x40], eax);         /* mov [ebp-0x40], eax */
            ii(0x100d_6dc0, 2); jmp(0x100d_6dc8, 6); goto l_0x100d_6dc8; /* jmp 0x100d6dc8 */
        l_0x100d_6dc2:
            ii(0x100d_6dc2, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x100d_6dc5, 3); mov(memd[ss, ebp - 0x40], eax);         /* mov [ebp-0x40], eax */
        l_0x100d_6dc8:
            ii(0x100d_6dc8, 3); mov(eax, memd[ss, ebp - 0x40]);         /* mov eax, [ebp-0x40] */
            ii(0x100d_6dcb, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x100d_6dce, 3); mov(memd[ds, edx + 0x1c], eax);         /* mov [edx+0x1c], eax */
            ii(0x100d_6dd1, 2); jmp(0x100d_6e48, 0x75); goto l_0x100d_6e48; /* jmp 0x100d6e48 */
        l_0x100d_6dd3:
            ii(0x100d_6dd3, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_6dd8, 5); call(Definitions.sys_new, 0x8_f023);    /* call 0x10165e00 */
            ii(0x100d_6ddd, 3); mov(memd[ss, ebp - 0x44], eax);         /* mov [ebp-0x44], eax */
            ii(0x100d_6de0, 3); mov(eax, memd[ss, ebp - 0x44]);         /* mov eax, [ebp-0x44] */
            ii(0x100d_6de3, 3); mov(memd[ss, ebp - 0x48], eax);         /* mov [ebp-0x48], eax */
            ii(0x100d_6de6, 4); cmp(memd[ss, ebp - 0x48], 0);           /* cmp dword [ebp-0x48], 0x0 */
            ii(0x100d_6dea, 2); if(jz(0x100d_6e39, 0x4d)) goto l_0x100d_6e39; /* jz 0x100d6e39 */
            ii(0x100d_6dec, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_6def, 4); mov(ax, memw[ds, eax + 0xc]);           /* mov ax, [eax+0xc] */
            ii(0x100d_6df3, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_6df6, 4); sub(ax, memw[ds, edx + 4]);             /* sub ax, [edx+0x4] */
            ii(0x100d_6dfa, 1); cwde();                                 /* cwde */
            ii(0x100d_6dfb, 1); push(eax);                              /* push eax */
            ii(0x100d_6dfc, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_6dff, 4); mov(ax, memw[ds, eax + 8]);             /* mov ax, [eax+0x8] */
            ii(0x100d_6e03, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_6e06, 3); sub(ax, memw[ds, edx]);                 /* sub ax, [edx] */
            ii(0x100d_6e09, 5); add(eax, 6);                            /* add eax, 0x6 */
            ii(0x100d_6e0e, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100d_6e11, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_6e14, 3); mov(ebx, memd[ds, eax + 2]);            /* mov ebx, [eax+0x2] */
            ii(0x100d_6e17, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100d_6e1a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_6e1d, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x100d_6e20, 3); sub(eax, 3);                            /* sub eax, 0x3 */
            ii(0x100d_6e23, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_6e26, 3); mov(eax, memd[ss, ebp - 0x44]);         /* mov eax, [ebp-0x44] */
            ii(0x100d_6e29, 5); call(0x100c_e39d, -0x8a91);             /* call 0x100ce39d */
            ii(0x100d_6e2e, 3); mov(memd[ss, ebp - 0x4c], eax);         /* mov [ebp-0x4c], eax */
            ii(0x100d_6e31, 3); mov(eax, memd[ss, ebp - 0x4c]);         /* mov eax, [ebp-0x4c] */
            ii(0x100d_6e34, 3); mov(memd[ss, ebp - 0x50], eax);         /* mov [ebp-0x50], eax */
            ii(0x100d_6e37, 2); jmp(0x100d_6e3f, 6); goto l_0x100d_6e3f; /* jmp 0x100d6e3f */
        l_0x100d_6e39:
            ii(0x100d_6e39, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x100d_6e3c, 3); mov(memd[ss, ebp - 0x50], eax);         /* mov [ebp-0x50], eax */
        l_0x100d_6e3f:
            ii(0x100d_6e3f, 3); mov(eax, memd[ss, ebp - 0x50]);         /* mov eax, [ebp-0x50] */
            ii(0x100d_6e42, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x100d_6e45, 3); mov(memd[ds, edx + 0x1c], eax);         /* mov [edx+0x1c], eax */
        l_0x100d_6e48:
            ii(0x100d_6e48, 3); mov(edx, memd[ss, ebp + 0x1c]);         /* mov edx, [ebp+0x1c] */
            ii(0x100d_6e4b, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_6e4e, 3); mov(eax, memd[ds, eax + 0x1c]);         /* mov eax, [eax+0x1c] */
            ii(0x100d_6e51, 5); call(0x100d_5164, -0x1cf2);             /* call 0x100d5164 */
            ii(0x100d_6e56, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_6e59, 3); mov(memd[ss, ebp - 0x54], eax);         /* mov [ebp-0x54], eax */
            ii(0x100d_6e5c, 3); mov(eax, memd[ss, ebp - 0x54]);         /* mov eax, [ebp-0x54] */
            ii(0x100d_6e5f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_6e61, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_6e62, 1); pop(edi);                               /* pop edi */
            ii(0x100d_6e63, 1); pop(esi);                               /* pop esi */
            ii(0x100d_6e64, 3); ret(0x18);                              /* ret 0x18 */
        }
    }
}
