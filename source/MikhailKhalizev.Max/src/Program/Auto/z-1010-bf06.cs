using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_bf06-e68adfe2")]
        public void Method_1010_bf06()
        {
            ii(0x1010_bf06, 5); push(0x3c0);                            /* push 0x3c0 */
            ii(0x1010_bf0b, 5); call(Definitions.sys_check_available_stack_size, 0x5_9e42); /* call 0x10165d52 */
            ii(0x1010_bf10, 1); push(ebx);                              /* push ebx */
            ii(0x1010_bf11, 1); push(ecx);                              /* push ecx */
            ii(0x1010_bf12, 1); push(edx);                              /* push edx */
            ii(0x1010_bf13, 1); push(esi);                              /* push esi */
            ii(0x1010_bf14, 1); push(edi);                              /* push edi */
            ii(0x1010_bf15, 1); push(ebp);                              /* push ebp */
            ii(0x1010_bf16, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_bf18, 6); sub(esp, 0x3a4);                        /* sub esp, 0x3a4 */
            ii(0x1010_bf1e, 3); mov(memb[ss, ebp - 4], al);             /* mov [ebp-0x4], al */
            ii(0x1010_bf21, 4); mov(memb[ss, ebp - 8], 0);              /* mov byte [ebp-0x8], 0x0 */
            ii(0x1010_bf25, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x1010_bf28, 6); mov(memb[ss, ebp - 0x38c], al);         /* mov [ebp-0x38c], al */
            ii(0x1010_bf2e, 6); lea(eax, memd[ss, ebp - 0x398]);        /* lea eax, [ebp-0x398] */
            ii(0x1010_bf34, 5); call(0x1010_aab1, -0x1488);             /* call 0x1010aab1 */
        l_0x1010_bf39:
            ii(0x1010_bf39, 7); cmp(memb[ds, 0x101c_5630], 1);          /* cmp byte [0x101c5630], 0x1 */
            ii(0x1010_bf40, 2); if(jnz(0x1010_bf47, 5)) goto l_0x1010_bf47; /* jnz 0x1010bf47 */
            ii(0x1010_bf42, 5); call(0x1012_ac94, 0x1_ed4d);            /* call 0x1012ac94 */
        l_0x1010_bf47:
            ii(0x1010_bf47, 5); call(/* sys */ 0x1016_b208, 0x5_f2bc);  /* call 0x1016b208 */
            ii(0x1010_bf4c, 6); mov(memd[ss, ebp - 0x38b], eax);        /* mov [ebp-0x38b], eax */
            ii(0x1010_bf52, 7); cmp(memd[ss, ebp - 0x38b], 0);          /* cmp dword [ebp-0x38b], 0x0 */
            ii(0x1010_bf59, 2); if(jle(0x1010_bf67, 0xc)) goto l_0x1010_bf67; /* jle 0x1010bf67 */
            ii(0x1010_bf5b, 10); cmp(memd[ss, ebp - 0x38b], 0x7000);    /* cmp dword [ebp-0x38b], 0x7000 */
            ii(0x1010_bf65, 2); if(jl(0x1010_bf69, 2)) goto l_0x1010_bf69; /* jl 0x1010bf69 */
        l_0x1010_bf67:
            ii(0x1010_bf67, 2); jmp(0x1010_bf6d, 4); goto l_0x1010_bf6d; /* jmp 0x1010bf6d */
        l_0x1010_bf69:
            ii(0x1010_bf69, 4); mov(memb[ss, ebp - 8], 0);              /* mov byte [ebp-0x8], 0x0 */
        l_0x1010_bf6d:
            ii(0x1010_bf6d, 4); cmp(memd[ss, ebp - 0x57], 0);           /* cmp dword [ebp-0x57], 0x0 */
            ii(0x1010_bf71, 6); if(jz(0x1010_bffc, 0x85)) goto l_0x1010_bffc; /* jz 0x1010bffc */
            ii(0x1010_bf77, 6); mov(edx, memd[ss, ebp - 0x38b]);        /* mov edx, [ebp-0x38b] */
            ii(0x1010_bf7d, 3); mov(eax, memd[ss, ebp - 0x57]);         /* mov eax, [ebp-0x57] */
            ii(0x1010_bf80, 5); call(0x100e_b283, -0x2_0d02);           /* call 0x100eb283 */
            ii(0x1010_bf85, 2); test(al, al);                           /* test al, al */
            ii(0x1010_bf87, 2); if(jz(0x1010_bfd6, 0x4d)) goto l_0x1010_bfd6; /* jz 0x1010bfd6 */
            ii(0x1010_bf89, 7); cmp(memd[ss, ebp - 0x38b], 0x1b);       /* cmp dword [ebp-0x38b], 0x1b */
            ii(0x1010_bf90, 2); if(jz(0x1010_bf9b, 9)) goto l_0x1010_bf9b; /* jz 0x1010bf9b */
            ii(0x1010_bf92, 7); cmp(memd[ss, ebp - 0x38b], 0xd);        /* cmp dword [ebp-0x38b], 0xd */
            ii(0x1010_bf99, 2); if(jnz(0x1010_bfc7, 0x2c)) goto l_0x1010_bfc7; /* jnz 0x1010bfc7 */
        l_0x1010_bf9b:
            ii(0x1010_bf9b, 7); cmp(memd[ss, ebp - 0x38b], 0xd);        /* cmp dword [ebp-0x38b], 0xd */
            ii(0x1010_bfa2, 2); if(jnz(0x1010_bfad, 9)) goto l_0x1010_bfad; /* jnz 0x1010bfad */
            ii(0x1010_bfa4, 7); mov(memb[ss, ebp - 0x39c], 1);          /* mov byte [ebp-0x39c], 0x1 */
            ii(0x1010_bfab, 2); jmp(0x1010_bfb4, 7); goto l_0x1010_bfb4; /* jmp 0x1010bfb4 */
        l_0x1010_bfad:
            ii(0x1010_bfad, 7); mov(memb[ss, ebp - 0x39c], 0);          /* mov byte [ebp-0x39c], 0x0 */
        l_0x1010_bfb4:
            ii(0x1010_bfb4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_bfb6, 6); mov(dl, memb[ss, ebp - 0x39c]);         /* mov dl, [ebp-0x39c] */
            ii(0x1010_bfbc, 6); lea(eax, memd[ss, ebp - 0x398]);        /* lea eax, [ebp-0x398] */
            ii(0x1010_bfc2, 5); call(0x1010_b523, -0xaa4);              /* call 0x1010b523 */
        l_0x1010_bfc7:
            ii(0x1010_bfc7, 10); mov(memd[ss, ebp - 0x38b], 0);         /* mov dword [ebp-0x38b], 0x0 */
            ii(0x1010_bfd1, 5); jmp(0x1010_c0bc, 0xe6); goto l_0x1010_c0bc; /* jmp 0x1010c0bc */
        l_0x1010_bfd6:
            ii(0x1010_bfd6, 7); cmp(memd[ss, ebp - 0x38b], 0);          /* cmp dword [ebp-0x38b], 0x0 */
            ii(0x1010_bfdd, 2); if(jle(0x1010_bffc, 0x1d)) goto l_0x1010_bffc; /* jle 0x1010bffc */
            ii(0x1010_bfdf, 5); mov(edx, 0xd);                          /* mov edx, 0xd */
            ii(0x1010_bfe4, 3); mov(eax, memd[ss, ebp - 0x57]);         /* mov eax, [ebp-0x57] */
            ii(0x1010_bfe7, 5); call(0x100e_b283, -0x2_0d69);           /* call 0x100eb283 */
            ii(0x1010_bfec, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1010_bff1, 6); lea(eax, memd[ss, ebp - 0x398]);        /* lea eax, [ebp-0x398] */
            ii(0x1010_bff7, 5); call(0x1010_b523, -0xad9);              /* call 0x1010b523 */
        l_0x1010_bffc:
            ii(0x1010_bffc, 10); mov(memd[ss, ebp - 0x3a0], 0);         /* mov dword [ebp-0x3a0], 0x0 */
            ii(0x1010_c006, 2); jmp(0x1010_c014, 0xc); goto l_0x1010_c014; /* jmp 0x1010c014 */
        l_0x1010_c008:
            ii(0x1010_c008, 6); mov(eax, memd[ss, ebp - 0x3a0]);        /* mov eax, [ebp-0x3a0] */
            ii(0x1010_c00e, 6); inc(memd[ss, ebp - 0x3a0]);             /* inc dword [ebp-0x3a0] */
        l_0x1010_c014:
            ii(0x1010_c014, 7); cmp(memd[ss, ebp - 0x3a0], 0x33);       /* cmp dword [ebp-0x3a0], 0x33 */
            ii(0x1010_c01b, 6); if(jge(0x1010_c0bc, 0x9b)) goto l_0x1010_c0bc; /* jge 0x1010c0bc */
            ii(0x1010_c021, 6); mov(eax, memd[ss, ebp - 0x3a0]);        /* mov eax, [ebp-0x3a0] */
            ii(0x1010_c027, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1010_c02a, 8); cmp(memd[ds, eax + ebp - 0x123], 0);    /* cmp dword [eax+ebp-0x123], 0x0 */
            ii(0x1010_c032, 6); if(jz(0x1010_c0b7, 0x7f)) goto l_0x1010_c0b7; /* jz 0x1010c0b7 */
            ii(0x1010_c038, 7); imul(edx, memd[ss, ebp - 0x3a0], 0xc);  /* imul edx, [ebp-0x3a0], 0xc */
            ii(0x1010_c03f, 6); mov(eax, memd[ss, ebp - 0x38b]);        /* mov eax, [ebp-0x38b] */
            ii(0x1010_c045, 7); cmp(eax, memd[ds, edx + ebp - 0x383]);  /* cmp eax, [edx+ebp-0x383] */
            ii(0x1010_c04c, 2); if(jnz(0x1010_c062, 0x14)) goto l_0x1010_c062; /* jnz 0x1010c062 */
            ii(0x1010_c04e, 7); imul(eax, memd[ss, ebp - 0x3a0], 0xc);  /* imul eax, [ebp-0x3a0], 0xc */
            ii(0x1010_c055, 7); mov(eax, memd[ds, eax + ebp - 0x387]);  /* mov eax, [eax+ebp-0x387] */
            ii(0x1010_c05c, 6); mov(memd[ss, ebp - 0x38b], eax);        /* mov [ebp-0x38b], eax */
        l_0x1010_c062:
            ii(0x1010_c062, 7); imul(edx, memd[ss, ebp - 0x3a0], 0xc);  /* imul edx, [ebp-0x3a0], 0xc */
            ii(0x1010_c069, 6); mov(eax, memd[ss, ebp - 0x38b]);        /* mov eax, [ebp-0x38b] */
            ii(0x1010_c06f, 7); cmp(eax, memd[ds, edx + ebp - 0x387]);  /* cmp eax, [edx+ebp-0x387] */
            ii(0x1010_c076, 2); if(jnz(0x1010_c0b7, 0x3f)) goto l_0x1010_c0b7; /* jnz 0x1010c0b7 */
            ii(0x1010_c078, 4); cmp(memb[ss, ebp - 8], 0);              /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1010_c07c, 2); if(jnz(0x1010_c093, 0x15)) goto l_0x1010_c093; /* jnz 0x1010c093 */
            ii(0x1010_c07e, 6); mov(eax, memd[ss, ebp - 0x3a0]);        /* mov eax, [ebp-0x3a0] */
            ii(0x1010_c084, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1010_c087, 7); mov(eax, memd[ds, eax + ebp - 0x123]);  /* mov eax, [eax+ebp-0x123] */
            ii(0x1010_c08e, 5); call(0x100c_fbbe, -0x3_c4d5);           /* call 0x100cfbbe */
        l_0x1010_c093:
            ii(0x1010_c093, 4); mov(memb[ss, ebp - 8], 1);              /* mov byte [ebp-0x8], 0x1 */
            ii(0x1010_c097, 10); add(memd[ss, ebp - 0x38b], 0xffff_fc18); /* add dword [ebp-0x38b], 0xfffffc18 */
            ii(0x1010_c0a1, 7); imul(edx, memd[ss, ebp - 0x3a0], 0xc);  /* imul edx, [ebp-0x3a0], 0xc */
            ii(0x1010_c0a8, 6); lea(eax, memd[ss, ebp - 0x398]);        /* lea eax, [ebp-0x398] */
            ii(0x1010_c0ae, 7); call_abs(memd[ds, edx + ebp - 0x37f]);  /* call dword [edx+ebp-0x37f] */
            ii(0x1010_c0b5, 2); jmp(0x1010_c0bc, 5); goto l_0x1010_c0bc; /* jmp 0x1010c0bc */
        l_0x1010_c0b7:
            ii(0x1010_c0b7, 5); jmp(0x1010_c008, -0xb4); goto l_0x1010_c008; /* jmp 0x1010c008 */
        l_0x1010_c0bc:
            ii(0x1010_c0bc, 7); cmp(memd[ss, ebp - 0x394], 0);          /* cmp dword [ebp-0x394], 0x0 */
            ii(0x1010_c0c3, 2); if(jnz(0x1010_c0ce, 9)) goto l_0x1010_c0ce; /* jnz 0x1010c0ce */
            ii(0x1010_c0c5, 7); cmp(memd[ss, ebp - 0x390], 0);          /* cmp dword [ebp-0x390], 0x0 */
            ii(0x1010_c0cc, 2); if(jz(0x1010_c0d0, 2)) goto l_0x1010_c0d0; /* jz 0x1010c0d0 */
        l_0x1010_c0ce:
            ii(0x1010_c0ce, 2); jmp(0x1010_c0d5, 5); goto l_0x1010_c0d5; /* jmp 0x1010c0d5 */
        l_0x1010_c0d0:
            ii(0x1010_c0d0, 5); jmp(0x1010_bf39, -0x19c); goto l_0x1010_bf39; /* jmp 0x1010bf39 */
        l_0x1010_c0d5:
            ii(0x1010_c0d5, 6); lea(eax, memd[ss, ebp - 0x398]);        /* lea eax, [ebp-0x398] */
            ii(0x1010_c0db, 5); call(0x1010_af4d, -0x1193);             /* call 0x1010af4d */
            ii(0x1010_c0e0, 6); mov(eax, memd[ss, ebp - 0x394]);        /* mov eax, [ebp-0x394] */
            ii(0x1010_c0e6, 6); mov(memd[ss, ebp - 0x3a4], eax);        /* mov [ebp-0x3a4], eax */
            ii(0x1010_c0ec, 6); mov(eax, memd[ss, ebp - 0x3a4]);        /* mov eax, [ebp-0x3a4] */
            ii(0x1010_c0f2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_c0f4, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_c0f5, 1); pop(edi);                               /* pop edi */
            ii(0x1010_c0f6, 1); pop(esi);                               /* pop esi */
            ii(0x1010_c0f7, 1); pop(edx);                               /* pop edx */
            ii(0x1010_c0f8, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_c0f9, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_c0fa, 1); ret();                                  /* ret */
        }
    }
}
