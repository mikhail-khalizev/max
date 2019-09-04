using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_fa3b-f61649f6")]
        public void Method_1008_fa3b()
        {
            ii(0x1008_fa3b, 5); push(0x3c);                             /* push 0x3c */
            ii(0x1008_fa40, 5); call(Definitions.sys_check_available_stack_size, 0xd_630d); /* call 0x10165d52 */
            ii(0x1008_fa45, 1); push(ebx);                              /* push ebx */
            ii(0x1008_fa46, 1); push(ecx);                              /* push ecx */
            ii(0x1008_fa47, 1); push(edx);                              /* push edx */
            ii(0x1008_fa48, 1); push(esi);                              /* push esi */
            ii(0x1008_fa49, 1); push(edi);                              /* push edi */
            ii(0x1008_fa4a, 1); push(ebp);                              /* push ebp */
            ii(0x1008_fa4b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_fa4d, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1008_fa53, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1008_fa56, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_fa58, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_fa5b, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_fa5e, 5); call(0x1013_ad11, 0xa_b2ae);            /* call 0x1013ad11 */
            ii(0x1008_fa63, 2); test(al, al);                           /* test al, al */
            ii(0x1008_fa65, 2); if(jz(0x1008_fa70, 9)) goto l_0x1008_fa70; /* jz 0x1008fa70 */
            ii(0x1008_fa67, 4); mov(memb[ss, ebp - 8], 0);              /* mov byte [ebp-0x8], 0x0 */
            ii(0x1008_fa6b, 5); jmp(0x1008_fcba, 0x24a); goto l_0x1008_fcba; /* jmp 0x1008fcba */
        l_0x1008_fa70:
            ii(0x1008_fa70, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1008_fa75, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_fa78, 3); mov(eax, memd[ds, eax + 17]);           /* mov eax, [eax+0x11] */
            ii(0x1008_fa7b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_fa7e, 5); call(0x1007_1e00, -0x1_dc83);           /* call 0x10071e00 */
            ii(0x1008_fa83, 1); cwde();                                 /* cwde */
            ii(0x1008_fa84, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_fa86, 2); if(jle(0x1008_faa4, 0x1c)) goto l_0x1008_faa4; /* jle 0x1008faa4 */
            ii(0x1008_fa88, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_fa8b, 3); mov(edx, memd[ds, eax + 17]);           /* mov edx, [eax+0x11] */
            ii(0x1008_fa8e, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_fa91, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_fa94, 3); mov(eax, memd[ds, eax + 7]);            /* mov eax, [eax+0x7] */
            ii(0x1008_fa97, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_fa9a, 5); call(0x100b_71dc, 0x2_773d);            /* call 0x100b71dc */
            ii(0x1008_fa9f, 1); cwde();                                 /* cwde */
            ii(0x1008_faa0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_faa2, 2); if(jg(0x1008_faa6, 2)) goto l_0x1008_faa6; /* jg 0x1008faa6 */
        l_0x1008_faa4:
            ii(0x1008_faa4, 2); jmp(0x1008_fab8, 0x12); goto l_0x1008_fab8; /* jmp 0x1008fab8 */
        l_0x1008_faa6:
            ii(0x1008_faa6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_faa9, 3); mov(eax, memd[ds, eax + 7]);            /* mov eax, [eax+0x7] */
            ii(0x1008_faac, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_faaf, 5); call(0x100a_5c69, 0x1_61b5);            /* call 0x100a5c69 */
            ii(0x1008_fab4, 2); test(al, al);                           /* test al, al */
            ii(0x1008_fab6, 2); if(jnz(0x1008_faba, 2)) goto l_0x1008_faba; /* jnz 0x1008faba */
        l_0x1008_fab8:
            ii(0x1008_fab8, 2); jmp(0x1008_faca, 0x10); goto l_0x1008_faca; /* jmp 0x1008faca */
        l_0x1008_faba:
            ii(0x1008_faba, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_fabd, 4); mov(memb[ds, eax + 37], 4);             /* mov byte [eax+0x25], 0x4 */
            ii(0x1008_fac1, 4); mov(memb[ss, ebp - 8], 0);              /* mov byte [ebp-0x8], 0x0 */
            ii(0x1008_fac5, 5); jmp(0x1008_fcba, 0x1f0); goto l_0x1008_fcba; /* jmp 0x1008fcba */
        l_0x1008_faca:
            ii(0x1008_faca, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_facd, 3); mov(eax, memd[ds, eax + 17]);           /* mov eax, [eax+0x11] */
            ii(0x1008_fad0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_fad3, 5); call(0x1007_1f2e, -0x1_dbaa);           /* call 0x10071f2e */
            ii(0x1008_fad8, 1); cwde();                                 /* cwde */
            ii(0x1008_fad9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_fadb, 2); if(jle(0x1008_faf9, 0x1c)) goto l_0x1008_faf9; /* jle 0x1008faf9 */
            ii(0x1008_fadd, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_fae0, 3); mov(edx, memd[ds, eax + 17]);           /* mov edx, [eax+0x11] */
            ii(0x1008_fae3, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_fae6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_fae9, 3); mov(eax, memd[ds, eax + 7]);            /* mov eax, [eax+0x7] */
            ii(0x1008_faec, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_faef, 5); call(0x100b_71dc, 0x2_76e8);            /* call 0x100b71dc */
            ii(0x1008_faf4, 1); cwde();                                 /* cwde */
            ii(0x1008_faf5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_faf7, 2); if(jg(0x1008_fafb, 2)) goto l_0x1008_fafb; /* jg 0x1008fafb */
        l_0x1008_faf9:
            ii(0x1008_faf9, 2); jmp(0x1008_fb3b, 0x40); goto l_0x1008_fb3b; /* jmp 0x1008fb3b */
        l_0x1008_fafb:
            ii(0x1008_fafb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_fafe, 3); mov(eax, memd[ds, eax + 7]);            /* mov eax, [eax+0x7] */
            ii(0x1008_fb01, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_fb04, 5); call(0x1008_b574, -0x4595);             /* call 0x1008b574 */
            ii(0x1008_fb09, 2); test(al, al);                           /* test al, al */
            ii(0x1008_fb0b, 2); if(jnz(0x1008_fb2b, 0x1e)) goto l_0x1008_fb2b; /* jnz 0x1008fb2b */
            ii(0x1008_fb0d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_fb10, 5); cmp(memw[ds, eax + 19], 0x28);          /* cmp word [eax+0x13], 0x28 */
            ii(0x1008_fb15, 2); if(jz(0x1008_fb29, 0x12)) goto l_0x1008_fb29; /* jz 0x1008fb29 */
            ii(0x1008_fb17, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_fb1a, 3); mov(eax, memd[ds, eax + 7]);            /* mov eax, [eax+0x7] */
            ii(0x1008_fb1d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_fb20, 5); call(0x1008_b874, -0x42b1);             /* call 0x1008b874 */
            ii(0x1008_fb25, 2); test(al, al);                           /* test al, al */
            ii(0x1008_fb27, 2); if(jnz(0x1008_fb2b, 2)) goto l_0x1008_fb2b; /* jnz 0x1008fb2b */
        l_0x1008_fb29:
            ii(0x1008_fb29, 2); jmp(0x1008_fb3b, 0x10); goto l_0x1008_fb3b; /* jmp 0x1008fb3b */
        l_0x1008_fb2b:
            ii(0x1008_fb2b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_fb2e, 4); mov(memb[ds, eax + 37], 4);             /* mov byte [eax+0x25], 0x4 */
            ii(0x1008_fb32, 4); mov(memb[ss, ebp - 8], 0);              /* mov byte [ebp-0x8], 0x0 */
            ii(0x1008_fb36, 5); jmp(0x1008_fcba, 0x17f); goto l_0x1008_fcba; /* jmp 0x1008fcba */
        l_0x1008_fb3b:
            ii(0x1008_fb3b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_fb3e, 3); mov(eax, memd[ds, eax + 17]);           /* mov eax, [eax+0x11] */
            ii(0x1008_fb41, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_fb44, 5); call(0x1007_1ff5, -0x1_db54);           /* call 0x10071ff5 */
            ii(0x1008_fb49, 1); cwde();                                 /* cwde */
            ii(0x1008_fb4a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_fb4c, 2); if(jle(0x1008_fb6a, 0x1c)) goto l_0x1008_fb6a; /* jle 0x1008fb6a */
            ii(0x1008_fb4e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_fb51, 3); mov(edx, memd[ds, eax + 17]);           /* mov edx, [eax+0x11] */
            ii(0x1008_fb54, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_fb57, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_fb5a, 3); mov(eax, memd[ds, eax + 7]);            /* mov eax, [eax+0x7] */
            ii(0x1008_fb5d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_fb60, 5); call(0x100b_71dc, 0x2_7677);            /* call 0x100b71dc */
            ii(0x1008_fb65, 1); cwde();                                 /* cwde */
            ii(0x1008_fb66, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_fb68, 2); if(jg(0x1008_fb6c, 2)) goto l_0x1008_fb6c; /* jg 0x1008fb6c */
        l_0x1008_fb6a:
            ii(0x1008_fb6a, 2); jmp(0x1008_fb7e, 0x12); goto l_0x1008_fb7e; /* jmp 0x1008fb7e */
        l_0x1008_fb6c:
            ii(0x1008_fb6c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_fb6f, 3); mov(eax, memd[ds, eax + 7]);            /* mov eax, [eax+0x7] */
            ii(0x1008_fb72, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_fb75, 5); call(0x1008_b6f4, -0x4486);             /* call 0x1008b6f4 */
            ii(0x1008_fb7a, 2); test(al, al);                           /* test al, al */
            ii(0x1008_fb7c, 2); if(jnz(0x1008_fb80, 2)) goto l_0x1008_fb80; /* jnz 0x1008fb80 */
        l_0x1008_fb7e:
            ii(0x1008_fb7e, 2); jmp(0x1008_fb90, 0x10); goto l_0x1008_fb90; /* jmp 0x1008fb90 */
        l_0x1008_fb80:
            ii(0x1008_fb80, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_fb83, 4); mov(memb[ds, eax + 37], 4);             /* mov byte [eax+0x25], 0x4 */
            ii(0x1008_fb87, 4); mov(memb[ss, ebp - 8], 0);              /* mov byte [ebp-0x8], 0x0 */
            ii(0x1008_fb8b, 5); jmp(0x1008_fcba, 0x12a); goto l_0x1008_fcba; /* jmp 0x1008fcba */
        l_0x1008_fb90:
            ii(0x1008_fb90, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_fb93, 3); mov(edx, memd[ds, eax + 7]);            /* mov edx, [eax+0x7] */
            ii(0x1008_fb96, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_fb99, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_fb9c, 3); mov(eax, memd[ds, eax + 17]);           /* mov eax, [eax+0x11] */
            ii(0x1008_fb9f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_fba2, 5); call(0x100d_4b64, 0x4_4fbd);            /* call 0x100d4b64 */
            ii(0x1008_fba7, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1008_fba9, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1008_fbae, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_fbb1, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_fbb4, 5); call(0x1007_6574, -0x1_9645);           /* call 0x10076574 */
            ii(0x1008_fbb9, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x1008_fbbc, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_fbbf, 5); call(0x1007_1e00, -0x1_ddc4);           /* call 0x10071e00 */
            ii(0x1008_fbc4, 3); imul(ebx, eax);                         /* imul ebx, eax */
            ii(0x1008_fbc7, 3); mov(memd[ss, ebp - 12], ebx);           /* mov [ebp-0xc], ebx */
            ii(0x1008_fbca, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_fbcd, 3); add(edx, 0x21);                         /* add edx, 0x21 */
            ii(0x1008_fbd0, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x1008_fbd3, 5); call(0x1007_5e64, -0x1_9d74);           /* call 0x10075e64 */
            ii(0x1008_fbd8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_fbda, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_fbdd, 3); mov(eax, memd[ds, eax + 17]);           /* mov eax, [eax+0x11] */
            ii(0x1008_fbe0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_fbe3, 5); call(0x1008_ba6a, -0x417e);             /* call 0x1008ba6a */
            ii(0x1008_fbe8, 2); cmp(al, 2);                             /* cmp al, 0x2 */
            ii(0x1008_fbea, 2); if(jnz(0x1008_fc09, 0x1d)) goto l_0x1008_fc09; /* jnz 0x1008fc09 */
            ii(0x1008_fbec, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_fbef, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_fbf2, 5); call(0x1007_6574, -0x1_9683);           /* call 0x10076574 */
            ii(0x1008_fbf7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_fbf9, 5); mov(eax, 0x21);                         /* mov eax, 0x21 */
            ii(0x1008_fbfe, 5); call(0x100c_defa, 0x3_e2f7);            /* call 0x100cdefa */
            ii(0x1008_fc03, 4); cmp(ax, memw[ds, edx + 8]);             /* cmp ax, [edx+0x8] */
            ii(0x1008_fc07, 2); if(jz(0x1008_fc0b, 2)) goto l_0x1008_fc0b; /* jz 0x1008fc0b */
        l_0x1008_fc09:
            ii(0x1008_fc09, 2); jmp(0x1008_fc41, 0x36); goto l_0x1008_fc41; /* jmp 0x1008fc41 */
        l_0x1008_fc0b:
            ii(0x1008_fc0b, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_fc0e, 3); mov(edx, memd[ds, edx + 7]);            /* mov edx, [edx+0x7] */
            ii(0x1008_fc11, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_fc14, 5); mov(eax, 0x21);                         /* mov eax, 0x21 */
            ii(0x1008_fc19, 5); call(0x100d_4b64, 0x4_4f46);            /* call 0x100d4b64 */
            ii(0x1008_fc1e, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1008_fc20, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1008_fc25, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_fc28, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_fc2b, 5); call(0x1007_6574, -0x1_96bc);           /* call 0x10076574 */
            ii(0x1008_fc30, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x1008_fc33, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_fc36, 5); call(0x1007_1e00, -0x1_de3b);           /* call 0x10071e00 */
            ii(0x1008_fc3b, 3); imul(eax, ebx);                         /* imul eax, ebx */
            ii(0x1008_fc3e, 3); add(memd[ss, ebp - 12], eax);           /* add [ebp-0xc], eax */
        l_0x1008_fc41:
            ii(0x1008_fc41, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_fc44, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_fc47, 5); call(0x1007_6574, -0x1_96d8);           /* call 0x10076574 */
            ii(0x1008_fc4c, 4); mov(ax, memw[ds, eax + 82]);            /* mov ax, [eax+0x52] */
            ii(0x1008_fc50, 4); cmp(ax, memw[ss, ebp - 12]);            /* cmp ax, [ebp-0xc] */
            ii(0x1008_fc54, 2); if(jl(0x1008_fc5c, 6)) goto l_0x1008_fc5c; /* jl 0x1008fc5c */
            ii(0x1008_fc56, 4); mov(memb[ss, ebp - 8], 1);              /* mov byte [ebp-0x8], 0x1 */
            ii(0x1008_fc5a, 2); jmp(0x1008_fcba, 0x5e); goto l_0x1008_fcba; /* jmp 0x1008fcba */
        l_0x1008_fc5c:
            ii(0x1008_fc5c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_fc5f, 4); mov(memb[ds, eax + 37], 4);             /* mov byte [eax+0x25], 0x4 */
            ii(0x1008_fc63, 5); mov(eax, 0x21);                         /* mov eax, 0x21 */
            ii(0x1008_fc68, 5); call(Definitions.sys_new, 0xd_6193);    /* call 0x10165e00 */
            ii(0x1008_fc6d, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x1008_fc70, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x1008_fc73, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1008_fc76, 4); cmp(memd[ss, ebp - 16], 0);             /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1008_fc7a, 2); if(jz(0x1008_fca3, 0x27)) goto l_0x1008_fca3; /* jz 0x1008fca3 */
            ii(0x1008_fc7c, 4); movsx(ecx, memw[ss, ebp - 12]);         /* movsx ecx, word [ebp-0xc] */
            ii(0x1008_fc80, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_fc83, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_fc86, 5); call(0x1007_65d0, -0x1_96bb);           /* call 0x100765d0 */
            ii(0x1008_fc8b, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1008_fc8d, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_fc90, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x1008_fc93, 5); call(0x1008_bd0b, -0x3f8d);             /* call 0x1008bd0b */
            ii(0x1008_fc98, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1008_fc9b, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1008_fc9e, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x1008_fca1, 2); jmp(0x1008_fca9, 6); goto l_0x1008_fca9; /* jmp 0x1008fca9 */
        l_0x1008_fca3:
            ii(0x1008_fca3, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1008_fca6, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
        l_0x1008_fca9:
            ii(0x1008_fca9, 3); mov(edx, memd[ss, ebp - 32]);           /* mov edx, [ebp-0x20] */
            ii(0x1008_fcac, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_fcb1, 5); call(0x100a_4d50, 0x1_509a);            /* call 0x100a4d50 */
            ii(0x1008_fcb6, 4); mov(memb[ss, ebp - 8], 0);              /* mov byte [ebp-0x8], 0x0 */
        l_0x1008_fcba:
            ii(0x1008_fcba, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1008_fcbd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_fcbf, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_fcc0, 1); pop(edi);                               /* pop edi */
            ii(0x1008_fcc1, 1); pop(esi);                               /* pop esi */
            ii(0x1008_fcc2, 1); pop(edx);                               /* pop edx */
            ii(0x1008_fcc3, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_fcc4, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_fcc5, 1); ret();                                  /* ret */
        }
    }
}
