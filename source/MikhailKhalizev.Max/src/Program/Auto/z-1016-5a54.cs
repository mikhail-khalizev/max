using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_5a54-9950fba9")]
        public void Method_1016_5a54()
        {
            ii(0x1016_5a54, 5); push(0x30);                             /* push 0x30 */
            ii(0x1016_5a59, 5); call(Definitions.sys_check_available_stack_size, 0x2f4); /* call 0x10165d52 */
            ii(0x1016_5a5e, 1); push(ebx);                              /* push ebx */
            ii(0x1016_5a5f, 1); push(ecx);                              /* push ecx */
            ii(0x1016_5a60, 1); push(esi);                              /* push esi */
            ii(0x1016_5a61, 1); push(edi);                              /* push edi */
            ii(0x1016_5a62, 1); push(ebp);                              /* push ebp */
            ii(0x1016_5a63, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_5a65, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1016_5a6b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1016_5a6e, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1016_5a71, 4); cmp(memd[ss, ebp - 4], 0);              /* cmp dword [ebp-0x4], 0x0 */
            ii(0x1016_5a75, 2); if(jle(0x1016_5a80, 9)) goto l_0x1016_5a80; /* jle 0x10165a80 */
            ii(0x1016_5a77, 7); cmp(memd[ss, ebp - 4], 0x7000);         /* cmp dword [ebp-0x4], 0x7000 */
            ii(0x1016_5a7e, 2); if(jl(0x1016_5a82, 2)) goto l_0x1016_5a82; /* jl 0x10165a82 */
        l_0x1016_5a80:
            ii(0x1016_5a80, 2); jmp(0x1016_5a89, 7); goto l_0x1016_5a89; /* jmp 0x10165a89 */
        l_0x1016_5a82:
            ii(0x1016_5a82, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_5a85, 4); mov(memb[ds, eax + 112], 0);            /* mov byte [eax+0x70], 0x0 */
        l_0x1016_5a89:
            ii(0x1016_5a89, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_5a8c, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1016_5a8f, 5); jmp(0x1016_5b85, 0xf1); goto l_0x1016_5b85; /* jmp 0x10165b85 */
        l_0x1016_5a94:
            ii(0x1016_5a94, 5); call(0x1011_6ba6, -0x4_eef3);           /* call 0x10116ba6 */
            ii(0x1016_5a99, 5); jmp(0x1016_5bcb, 0x12d); goto l_0x1016_5bcb; /* jmp 0x10165bcb */
        l_0x1016_5a9e:
            ii(0x1016_5a9e, 5); call(0x100d_4e6c, -0x9_0c37);           /* call 0x100d4e6c */
            ii(0x1016_5aa3, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_5aa5, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1016_5aa7, 5); mov(edx, 0x26);                         /* mov edx, 0x26 */
            ii(0x1016_5aac, 5); mov(eax, 0xf);                          /* mov eax, 0xf */
            ii(0x1016_5ab1, 5); call(0x1010_5b00, -0x5_ffb6);           /* call 0x10105b00 */
            ii(0x1016_5ab6, 5); jmp(0x1016_5bcb, 0x110); goto l_0x1016_5bcb; /* jmp 0x10165bcb */
        l_0x1016_5abb:
            ii(0x1016_5abb, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_5abe, 6); mov(memw[ds, eax + 23], 0);             /* mov word [eax+0x17], 0x0 */
        l_0x1016_5ac4:
            ii(0x1016_5ac4, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_5ac7, 4); mov(memb[ds, eax + 71], 1);             /* mov byte [eax+0x47], 0x1 */
            ii(0x1016_5acb, 5); jmp(0x1016_5bcb, 0xfb); goto l_0x1016_5bcb; /* jmp 0x10165bcb */
        l_0x1016_5ad0:
            ii(0x1016_5ad0, 7); cmp(memd[ss, ebp - 4], 0x7000);         /* cmp dword [ebp-0x4], 0x7000 */
            ii(0x1016_5ad7, 2); if(jl(0x1016_5b29, 0x50)) goto l_0x1016_5b29; /* jl 0x10165b29 */
            ii(0x1016_5ad9, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_5adc, 4); cmp(memb[ds, eax + 112], 0);            /* cmp byte [eax+0x70], 0x0 */
            ii(0x1016_5ae0, 2); if(jnz(0x1016_5b27, 0x45)) goto l_0x1016_5b27; /* jnz 0x10165b27 */
            ii(0x1016_5ae2, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_5ae5, 4); mov(memb[ds, eax + 112], 1);            /* mov byte [eax+0x70], 0x1 */
            ii(0x1016_5ae9, 7); add(memd[ss, ebp - 4], 0xffff_9000);    /* add dword [ebp-0x4], 0xffff9000 */
            ii(0x1016_5af0, 4); cmp(memd[ss, ebp - 4], 0xd);            /* cmp dword [ebp-0x4], 0xd */
            ii(0x1016_5af4, 2); if(jnz(0x1016_5b03, 0xd)) goto l_0x1016_5b03; /* jnz 0x10165b03 */
            ii(0x1016_5af6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_5af9, 3); mov(eax, memd[ds, eax + 76]);           /* mov eax, [eax+0x4c] */
            ii(0x1016_5afc, 5); call(0x100c_fbbe, -0x9_5f43);           /* call 0x100cfbbe */
            ii(0x1016_5b01, 2); jmp(0x1016_5b27, 0x24); goto l_0x1016_5b27; /* jmp 0x10165b27 */
        l_0x1016_5b03:
            ii(0x1016_5b03, 4); cmp(memd[ss, ebp - 4], 0x3f);           /* cmp dword [ebp-0x4], 0x3f */
            ii(0x1016_5b07, 2); if(jnz(0x1016_5b16, 0xd)) goto l_0x1016_5b16; /* jnz 0x10165b16 */
            ii(0x1016_5b09, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_5b0c, 3); mov(eax, memd[ds, eax + 80]);           /* mov eax, [eax+0x50] */
            ii(0x1016_5b0f, 5); call(0x100c_fbbe, -0x9_5f56);           /* call 0x100cfbbe */
            ii(0x1016_5b14, 2); jmp(0x1016_5b27, 0x11); goto l_0x1016_5b27; /* jmp 0x10165b27 */
        l_0x1016_5b16:
            ii(0x1016_5b16, 4); cmp(memd[ss, ebp - 4], 0x1b);           /* cmp dword [ebp-0x4], 0x1b */
            ii(0x1016_5b1a, 2); if(jnz(0x1016_5b27, 0xb)) goto l_0x1016_5b27; /* jnz 0x10165b27 */
            ii(0x1016_5b1c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_5b1f, 3); mov(eax, memd[ds, eax + 72]);           /* mov eax, [eax+0x48] */
            ii(0x1016_5b22, 5); call(0x100c_fbbe, -0x9_5f69);           /* call 0x100cfbbe */
        l_0x1016_5b27:
            ii(0x1016_5b27, 2); jmp(0x1016_5b83, 0x5a); goto l_0x1016_5b83; /* jmp 0x10165b83 */
        l_0x1016_5b29:
            ii(0x1016_5b29, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_5b2c, 3); mov(eax, memd[ds, eax + 96]);           /* mov eax, [eax+0x60] */
            ii(0x1016_5b2f, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1016_5b32, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1016_5b35, 3); mov(ebx, memd[ds, eax + 39]);           /* mov ebx, [eax+0x27] */
            ii(0x1016_5b38, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1016_5b3b, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1016_5b3e, 3); call_abs(memd[ds, ebx + 12]);           /* call dword [ebx+0xc] */
            ii(0x1016_5b41, 2); test(al, al);                           /* test al, al */
            ii(0x1016_5b43, 2); if(jz(0x1016_5b83, 0x3e)) goto l_0x1016_5b83; /* jz 0x10165b83 */
            ii(0x1016_5b45, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_5b48, 4); mov(ax, memw[ds, eax + 23]);            /* mov ax, [eax+0x17] */
            ii(0x1016_5b4c, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1016_5b4f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_5b52, 3); mov(eax, memd[ds, eax + 96]);           /* mov eax, [eax+0x60] */
            ii(0x1016_5b55, 5); call(0x100e_0b0c, -0x8_504e);           /* call 0x100e0b0c */
            ii(0x1016_5b5a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_5b5c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_5b5f, 4); mov(memw[ds, eax + 23], dx);            /* mov [eax+0x17], dx */
            ii(0x1016_5b63, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_5b66, 4); mov(ax, memw[ds, eax + 23]);            /* mov ax, [eax+0x17] */
            ii(0x1016_5b6a, 4); cmp(ax, memw[ss, ebp - 24]);            /* cmp ax, [ebp-0x18] */
            ii(0x1016_5b6e, 2); if(jz(0x1016_5b83, 0x13)) goto l_0x1016_5b83; /* jz 0x10165b83 */
            ii(0x1016_5b70, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_5b73, 3); mov(eax, memd[ds, eax + 84]);           /* mov eax, [eax+0x54] */
            ii(0x1016_5b76, 5); call(0x100c_fbbe, -0x9_5fbd);           /* call 0x100cfbbe */
            ii(0x1016_5b7b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_5b7e, 5); call(0x1016_585f, -0x324);              /* call 0x1016585f */
        l_0x1016_5b83:
            ii(0x1016_5b83, 2); jmp(0x1016_5bcb, 0x46); goto l_0x1016_5bcb; /* jmp 0x10165bcb */
        l_0x1016_5b85:
            ii(0x1016_5b85, 4); cmp(memd[ss, ebp - 16], 0x1b);          /* cmp dword [ebp-0x10], 0x1b */
            ii(0x1016_5b89, 2); if(jb(0x1016_5bbc, 0x31)) goto l_0x1016_5bbc; /* jb 0x10165bbc */
            ii(0x1016_5b8b, 4); cmp(memd[ss, ebp - 16], 0x1b);          /* cmp dword [ebp-0x10], 0x1b */
            ii(0x1016_5b8f, 6); if(jbe(0x1016_5abb, -0xda)) goto l_0x1016_5abb; /* jbe 0x10165abb */
            ii(0x1016_5b95, 4); cmp(memd[ss, ebp - 16], 0x3f);          /* cmp dword [ebp-0x10], 0x3f */
            ii(0x1016_5b99, 2); if(jb(0x1016_5bb7, 0x1c)) goto l_0x1016_5bb7; /* jb 0x10165bb7 */
            ii(0x1016_5b9b, 4); cmp(memd[ss, ebp - 16], 0x3f);          /* cmp dword [ebp-0x10], 0x3f */
            ii(0x1016_5b9f, 6); if(jbe(0x1016_5a9e, -0x107)) goto l_0x1016_5a9e; /* jbe 0x10165a9e */
            ii(0x1016_5ba5, 7); cmp(memd[ss, ebp - 16], 0x119);         /* cmp dword [ebp-0x10], 0x119 */
            ii(0x1016_5bac, 6); if(jz(0x1016_5a94, -0x11e)) goto l_0x1016_5a94; /* jz 0x10165a94 */
            ii(0x1016_5bb2, 5); jmp(0x1016_5ad0, -0xe7); goto l_0x1016_5ad0; /* jmp 0x10165ad0 */
        l_0x1016_5bb7:
            ii(0x1016_5bb7, 5); jmp(0x1016_5ad0, -0xec); goto l_0x1016_5ad0; /* jmp 0x10165ad0 */
        l_0x1016_5bbc:
            ii(0x1016_5bbc, 4); cmp(memd[ss, ebp - 16], 0xd);           /* cmp dword [ebp-0x10], 0xd */
            ii(0x1016_5bc0, 6); if(jz(0x1016_5ac4, -0x102)) goto l_0x1016_5ac4; /* jz 0x10165ac4 */
            ii(0x1016_5bc6, 5); jmp(0x1016_5ad0, -0xfb); goto l_0x1016_5ad0; /* jmp 0x10165ad0 */
        l_0x1016_5bcb:
            ii(0x1016_5bcb, 4); mov(memb[ss, ebp - 12], 1);             /* mov byte [ebp-0xc], 0x1 */
            ii(0x1016_5bcf, 3); mov(al, memb[ss, ebp - 12]);            /* mov al, [ebp-0xc] */
            ii(0x1016_5bd2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_5bd4, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_5bd5, 1); pop(edi);                               /* pop edi */
            ii(0x1016_5bd6, 1); pop(esi);                               /* pop esi */
            ii(0x1016_5bd7, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_5bd8, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_5bd9, 1); ret();                                  /* ret */
        }
    }
}
