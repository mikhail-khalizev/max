using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("00465b23-d151-42bc-b43e-48f9a9d3f0e7")]
        public void Method_1012_9cc6()
        {
            ii(0x1012_9cc6, 5); pushd(0x40);                            /* push 0x40 */
            ii(0x1012_9ccb, 5); calld(Definitions.sys_check_available_stack_size, 0x3_c082); /* call 0x10165d52 */
            ii(0x1012_9cd0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_9cd1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_9cd2, 1); pushd(edx);                             /* push edx */
            ii(0x1012_9cd3, 1); pushd(esi);                             /* push esi */
            ii(0x1012_9cd4, 1); pushd(edi);                             /* push edi */
            ii(0x1012_9cd5, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_9cd6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_9cd8, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1012_9cde, 5); mov(al, memb_a32[ds, 0x101c_59c8]);     /* mov al, [0x101c59c8] */
            ii(0x1012_9ce3, 3); mov(memb_a32[ss, ebp - 0x4], al);       /* mov [ebp-0x4], al */
            ii(0x1012_9ce6, 5); jmpd(0x1012_9f4b, 0x260); goto l_0x1012_9f4b; /* jmp 0x10129f4b */
        l_0x1012_9ceb:
            ii(0x1012_9ceb, 8); cmp(memw_a32[ds, 0x101b_b458], 0);      /* cmp word [0x101bb458], 0x0 */
            ii(0x1012_9cf3, 6); if(jzd(0x1012_9f8d, 0x294)) goto l_0x1012_9f8d; /* jz 0x10129f8d */
        l_0x1012_9cf9:
            ii(0x1012_9cf9, 6); mov(edx, memd_a32[ds, 0x101c_5878]);    /* mov edx, [0x101c5878] */
            ii(0x1012_9cff, 5); mov(eax, memd_a32[ds, 0x101c_587c]);    /* mov eax, [0x101c587c] */
            ii(0x1012_9d04, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1012_9d06, 2); cmp(edx, memd_a32[ds, eax]);            /* cmp edx, [eax] */
            ii(0x1012_9d08, 2); if(jzd(0x1012_9d14, 0xa)) goto l_0x1012_9d14; /* jz 0x10129d14 */
            ii(0x1012_9d0a, 5); calld(/* sys */ 0x1016_b208, 0x4_14f9); /* call 0x1016b208 */
            ii(0x1012_9d0f, 3); cmp(eax, 0x1b);                         /* cmp eax, 0x1b */
            ii(0x1012_9d12, 2); if(jnzd(0x1012_9cf9, -0x1b)) goto l_0x1012_9cf9; /* jnz 0x10129cf9 */
        l_0x1012_9d14:
            ii(0x1012_9d14, 5); mov(eax, 0x12_34dc);                    /* mov eax, 0x1234dc */
            ii(0x1012_9d19, 5); calld(0x1014_8574, 0x1_e856);           /* call 0x10148574 */
            ii(0x1012_9d1e, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1012_9d20, 5); mov(edx, 0x3);                          /* mov edx, 0x3 */
            ii(0x1012_9d25, 5); mov(eax, StringDefinitions.Control28);  /* mov eax, 0x101a83cd */
            ii(0x1012_9d2a, 5); calld(0x1012_4890, -0x549f);            /* call 0x10124890 */
            ii(0x1012_9d2f, 5); mov(eax, 0x24_69b8);                    /* mov eax, 0x2469b8 */
            ii(0x1012_9d34, 5); calld(0x1014_8574, 0x1_e83b);           /* call 0x10148574 */
            ii(0x1012_9d39, 5); mov(eax, 0x60);                         /* mov eax, 0x60 */
            ii(0x1012_9d3e, 5); calld(0x1012_4dd5, -0x4f6e);            /* call 0x10124dd5 */
        l_0x1012_9d43:
            ii(0x1012_9d43, 8); cmp(memw_a32[ds, 0x101b_b458], 0);      /* cmp word [0x101bb458], 0x0 */
            ii(0x1012_9d4b, 6); if(jzd(0x1012_9f8d, 0x23c)) goto l_0x1012_9f8d; /* jz 0x10129f8d */
        l_0x1012_9d51:
            ii(0x1012_9d51, 6); mov(edx, memd_a32[ds, 0x101c_5878]);    /* mov edx, [0x101c5878] */
            ii(0x1012_9d57, 5); mov(eax, memd_a32[ds, 0x101c_587c]);    /* mov eax, [0x101c587c] */
            ii(0x1012_9d5c, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1012_9d5e, 2); cmp(edx, memd_a32[ds, eax]);            /* cmp edx, [eax] */
            ii(0x1012_9d60, 2); if(jzd(0x1012_9d6c, 0xa)) goto l_0x1012_9d6c; /* jz 0x10129d6c */
            ii(0x1012_9d62, 5); calld(/* sys */ 0x1016_b208, 0x4_14a1); /* call 0x1016b208 */
            ii(0x1012_9d67, 3); cmp(eax, 0x1b);                         /* cmp eax, 0x1b */
            ii(0x1012_9d6a, 2); if(jnzd(0x1012_9d51, -0x1b)) goto l_0x1012_9d51; /* jnz 0x10129d51 */
        l_0x1012_9d6c:
            ii(0x1012_9d6c, 5); mov(eax, 0x9_1a6e);                     /* mov eax, 0x91a6e */
            ii(0x1012_9d71, 5); calld(0x1014_8574, 0x1_e7fe);           /* call 0x10148574 */
            ii(0x1012_9d76, 9); mov(memw_a32[ds, 0x101b_b458], 0);      /* mov word [0x101bb458], 0x0 */
            ii(0x1012_9d7f, 1); cli();                                  /* cli */
            ii(0x1012_9d80, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1012_9d82, 6); mov(cl, memb_a32[ds, 0x101b_b45a]);     /* mov cl, [0x101bb45a] */
            ii(0x1012_9d88, 3); sub(ecx, 0x8);                          /* sub ecx, 0x8 */
            ii(0x1012_9d8b, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1012_9d90, 2); shl(ebx, cl);                           /* shl ebx, cl */
            ii(0x1012_9d92, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_9d94, 5); mov(al, memb_a32[ds, 0x101c_5990]);     /* mov al, [0x101c5990] */
            ii(0x1012_9d99, 2); and(ebx, eax);                          /* and ebx, eax */
            ii(0x1012_9d9b, 5); mov(edx, 0x21);                         /* mov edx, 0x21 */
            ii(0x1012_9da0, 2); sub(eax, eax);                          /* sub eax, eax */
            ii(0x1012_9da2, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1012_9da3, 2); or(eax, ebx);                           /* or eax, ebx */
            ii(0x1012_9da5, 5); mov(edx, 0x21);                         /* mov edx, 0x21 */
            ii(0x1012_9daa, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1012_9dab, 5); mov(al, memb_a32[ds, 0x101c_599e]);     /* mov al, [0x101c599e] */
            ii(0x1012_9db0, 2); and(al, 0x7f);                          /* and al, 0x7f */
            ii(0x1012_9db2, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_9db7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_9db9, 7); mov(dx, memw_a32[ds, 0x101b_b45c]);     /* mov dx, [0x101bb45c] */
            ii(0x1012_9dc0, 3); add(edx, 0x3);                          /* add edx, 0x3 */
            ii(0x1012_9dc3, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1012_9dc4, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_9dc6, 5); mov(al, memb_a32[ds, 0x101c_599c]);     /* mov al, [0x101c599c] */
            ii(0x1012_9dcb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_9dcd, 7); mov(dx, memw_a32[ds, 0x101b_b45c]);     /* mov dx, [0x101bb45c] */
            ii(0x1012_9dd4, 1); inc(edx);                               /* inc edx */
            ii(0x1012_9dd5, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1012_9dd6, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_9dd8, 5); mov(al, memb_a32[ds, 0x101c_599f]);     /* mov al, [0x101c599f] */
            ii(0x1012_9ddd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_9ddf, 7); mov(dx, memw_a32[ds, 0x101b_b45c]);     /* mov dx, [0x101bb45c] */
            ii(0x1012_9de6, 3); add(edx, 0x4);                          /* add edx, 0x4 */
            ii(0x1012_9de9, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1012_9dea, 5); mov(al, memb_a32[ds, 0x101c_599e]);     /* mov al, [0x101c599e] */
            ii(0x1012_9def, 2); or(al, 0x80);                           /* or al, 0x80 */
            ii(0x1012_9df1, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_9df6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_9df8, 7); mov(dx, memw_a32[ds, 0x101b_b45c]);     /* mov dx, [0x101bb45c] */
            ii(0x1012_9dff, 3); add(edx, 0x3);                          /* add edx, 0x3 */
            ii(0x1012_9e02, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1012_9e03, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_9e05, 5); mov(al, memb_a32[ds, 0x101c_599a]);     /* mov al, [0x101c599a] */
            ii(0x1012_9e0a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_9e0c, 7); mov(dx, memw_a32[ds, 0x101b_b45c]);     /* mov dx, [0x101bb45c] */
            ii(0x1012_9e13, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1012_9e14, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_9e16, 5); mov(al, memb_a32[ds, 0x101c_599b]);     /* mov al, [0x101c599b] */
            ii(0x1012_9e1b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_9e1d, 7); mov(dx, memw_a32[ds, 0x101b_b45c]);     /* mov dx, [0x101bb45c] */
            ii(0x1012_9e24, 1); inc(edx);                               /* inc edx */
            ii(0x1012_9e25, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1012_9e26, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_9e28, 5); mov(al, memb_a32[ds, 0x101c_599e]);     /* mov al, [0x101c599e] */
            ii(0x1012_9e2d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_9e2f, 7); mov(dx, memw_a32[ds, 0x101b_b45c]);     /* mov dx, [0x101bb45c] */
            ii(0x1012_9e36, 3); add(edx, 0x3);                          /* add edx, 0x3 */
            ii(0x1012_9e39, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1012_9e3a, 1); sti();                                  /* sti */
            ii(0x1012_9e3b, 1); cld();                                  /* cld */
            ii(0x1012_9e3c, 6); mov(memw_a32[ss, ebp - 0x20], 0x201);   /* mov word [ebp-0x20], 0x201 */
            ii(0x1012_9e42, 5); mov(al, memb_a32[ds, 0x101b_b45a]);     /* mov al, [0x101bb45a] */
            ii(0x1012_9e47, 3); mov(memb_a32[ss, ebp - 0x1c], al);      /* mov [ebp-0x1c], al */
            ii(0x1012_9e4a, 6); mov(ax, memw_a32[ds, 0x101c_59a4]);     /* mov ax, [0x101c59a4] */
            ii(0x1012_9e50, 4); mov(memw_a32[ss, ebp - 0x18], ax);      /* mov [ebp-0x18], ax */
            ii(0x1012_9e54, 6); mov(ax, memw_a32[ds, 0x101c_59a6]);     /* mov ax, [0x101c59a6] */
            ii(0x1012_9e5a, 4); mov(memw_a32[ss, ebp - 0x14], ax);      /* mov [ebp-0x14], ax */
            ii(0x1012_9e5e, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x1012_9e61, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x1012_9e64, 5); mov(eax, 0x31);                         /* mov eax, 0x31 */
            ii(0x1012_9e69, 5); calld(/* sys */ 0x1016_c606, 0x4_2798); /* call 0x1016c606 */
            ii(0x1012_9e6e, 7); mov(memd_a32[ss, ebp - 0x20], 0x101);   /* mov dword [ebp-0x20], 0x101 */
            ii(0x1012_9e75, 6); mov(ax, memw_a32[ds, 0x101c_5988]);     /* mov ax, [0x101c5988] */
            ii(0x1012_9e7b, 4); mov(memw_a32[ss, ebp - 0x14], ax);      /* mov [ebp-0x14], ax */
            ii(0x1012_9e7f, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x1012_9e82, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x1012_9e85, 5); mov(eax, 0x31);                         /* mov eax, 0x31 */
            ii(0x1012_9e8a, 5); calld(/* sys */ 0x1016_c606, 0x4_2777); /* call 0x1016c606 */
            ii(0x1012_9e8f, 7); mov(memd_a32[ss, ebp - 0x20], 0x205);   /* mov dword [ebp-0x20], 0x205 */
            ii(0x1012_9e96, 5); mov(al, memb_a32[ds, 0x101b_b45a]);     /* mov al, [0x101bb45a] */
            ii(0x1012_9e9b, 3); mov(memb_a32[ss, ebp - 0x1b], al);      /* mov [ebp-0x1b], al */
            ii(0x1012_9e9e, 6); mov(ax, memw_a32[ds, 0x101c_59ac]);     /* mov ax, [0x101c59ac] */
            ii(0x1012_9ea4, 4); mov(memw_a32[ss, ebp - 0x18], ax);      /* mov [ebp-0x18], ax */
            ii(0x1012_9ea8, 5); mov(eax, memd_a32[ds, 0x101c_59a8]);    /* mov eax, [0x101c59a8] */
            ii(0x1012_9ead, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1012_9eb0, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x1012_9eb3, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x1012_9eb6, 5); mov(eax, 0x31);                         /* mov eax, 0x31 */
            ii(0x1012_9ebb, 5); calld(/* sys */ 0x1016_c606, 0x4_2746); /* call 0x1016c606 */
            ii(0x1012_9ec0, 7); mov(memd_a32[ss, ebp - 0x20], 0x601);   /* mov dword [ebp-0x20], 0x601 */
            ii(0x1012_9ec7, 2); mov(eax, cs);                           /* mov eax, cs */
            ii(0x1012_9ec9, 5); mov(edx, 0x100c_dc26);                  /* mov edx, 0x100cdc26 */
            ii(0x1012_9ece, 3); shr(edx, 0x10);                         /* shr edx, 0x10 */
            ii(0x1012_9ed1, 3); mov(memd_a32[ss, ebp - 0x1c], edx);     /* mov [ebp-0x1c], edx */
            ii(0x1012_9ed4, 2); mov(eax, cs);                           /* mov eax, cs */
            ii(0x1012_9ed6, 5); mov(edx, 0x100c_dc26);                  /* mov edx, 0x100cdc26 */
            ii(0x1012_9edb, 6); and(edx, 0xffff);                       /* and edx, 0xffff */
            ii(0x1012_9ee1, 3); mov(memd_a32[ss, ebp - 0x18], edx);     /* mov [ebp-0x18], edx */
            ii(0x1012_9ee4, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1012_9eeb, 5); mov(eax, memd_a32[ds, 0x100c_ddd5]);    /* mov eax, [0x100cddd5] */
            ii(0x1012_9ef0, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1012_9ef3, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x1012_9ef6, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x1012_9ef9, 5); mov(eax, 0x31);                         /* mov eax, 0x31 */
            ii(0x1012_9efe, 5); calld(/* sys */ 0x1016_c606, 0x4_2703); /* call 0x1016c606 */
            ii(0x1012_9f03, 7); mov(memd_a32[ss, ebp - 0x20], 0x601);   /* mov dword [ebp-0x20], 0x601 */
            ii(0x1012_9f0a, 5); mov(eax, 0x101b_b45c);                  /* mov eax, 0x101bb45c */
            ii(0x1012_9f0f, 3); shr(eax, 0x10);                         /* shr eax, 0x10 */
            ii(0x1012_9f12, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1012_9f15, 5); mov(eax, 0x101b_b45c);                  /* mov eax, 0x101bb45c */
            ii(0x1012_9f1a, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1012_9f1f, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1012_9f22, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1012_9f29, 7); mov(memd_a32[ss, ebp - 0xc], 0x2);      /* mov dword [ebp-0xc], 0x2 */
            ii(0x1012_9f30, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x1012_9f33, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x1012_9f36, 5); mov(eax, 0x31);                         /* mov eax, 0x31 */
            ii(0x1012_9f3b, 5); calld(/* sys */ 0x1016_c606, 0x4_26c6); /* call 0x1016c606 */
            ii(0x1012_9f40, 2); jmpd(0x1012_9f75, 0x33); goto l_0x1012_9f75; /* jmp 0x10129f75 */
        l_0x1012_9f42:
            ii(0x1012_9f42, 5); calld(0x1010_7903, -0x2_2644);          /* call 0x10107903 */
            ii(0x1012_9f47, 2); jmpd(0x1012_9f75, 0x2c); goto l_0x1012_9f75; /* jmp 0x10129f75 */
        l_0x1012_9f49:
            ii(0x1012_9f49, 2); jmpd(0x1012_9f75, 0x2a); goto l_0x1012_9f75; /* jmp 0x10129f75 */
        l_0x1012_9f4b:
            ii(0x1012_9f4b, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1012_9f4e, 3); mov(memb_a32[ss, ebp - 0x24], al);      /* mov [ebp-0x24], al */
            ii(0x1012_9f51, 4); cmp(memb_a32[ss, ebp - 0x24], 0x2);     /* cmp byte [ebp-0x24], 0x2 */
            ii(0x1012_9f55, 2); if(jbd(0x1012_9f69, 0x12)) goto l_0x1012_9f69; /* jb 0x10129f69 */
            ii(0x1012_9f57, 4); cmp(memb_a32[ss, ebp - 0x24], 0x2);     /* cmp byte [ebp-0x24], 0x2 */
            ii(0x1012_9f5b, 6); if(jbed(0x1012_9ceb, -0x276)) goto l_0x1012_9ceb; /* jbe 0x10129ceb */
            ii(0x1012_9f61, 4); cmp(memb_a32[ss, ebp - 0x24], 0x3);     /* cmp byte [ebp-0x24], 0x3 */
            ii(0x1012_9f65, 2); if(jzd(0x1012_9f42, -0x25)) goto l_0x1012_9f42; /* jz 0x10129f42 */
            ii(0x1012_9f67, 2); jmpd(0x1012_9f49, -0x20); goto l_0x1012_9f49; /* jmp 0x10129f49 */
        l_0x1012_9f69:
            ii(0x1012_9f69, 4); cmp(memb_a32[ss, ebp - 0x24], 0x1);     /* cmp byte [ebp-0x24], 0x1 */
            ii(0x1012_9f6d, 6); if(jzd(0x1012_9d43, -0x230)) goto l_0x1012_9d43; /* jz 0x10129d43 */
            ii(0x1012_9f73, 2); jmpd(0x1012_9f49, -0x2c); goto l_0x1012_9f49; /* jmp 0x10129f49 */
        l_0x1012_9f75:
            ii(0x1012_9f75, 7); mov(memb_a32[ds, 0x101c_5630], 0);      /* mov byte [0x101c5630], 0x0 */
            ii(0x1012_9f7c, 7); mov(memb_a32[ds, 0x101c_59c8], 0);      /* mov byte [0x101c59c8], 0x0 */
            ii(0x1012_9f83, 10); mov(memd_a32[ds, 0x101c_5624], 0);     /* mov dword [0x101c5624], 0x0 */
        l_0x1012_9f8d:
            ii(0x1012_9f8d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_9f8f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_9f90, 1); popd(edi);                              /* pop edi */
            ii(0x1012_9f91, 1); popd(esi);                              /* pop esi */
            ii(0x1012_9f92, 1); popd(edx);                              /* pop edx */
            ii(0x1012_9f93, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_9f94, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_9f95, 1); retd(); return;                         /* ret */
        }
    }
}
