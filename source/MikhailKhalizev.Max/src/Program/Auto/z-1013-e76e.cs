using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_e76e-63c2ad4b")]
        public void Method_1013_e76e()
        {
            ii(0x1013_e76e, 5); push(0x40);                             /* push 0x40 */
            ii(0x1013_e773, 5); call(Definitions.sys_check_available_stack_size, 0x2_75da); /* call 0x10165d52 */
            ii(0x1013_e778, 1); push(ebx);                              /* push ebx */
            ii(0x1013_e779, 1); push(ecx);                              /* push ecx */
            ii(0x1013_e77a, 1); push(esi);                              /* push esi */
            ii(0x1013_e77b, 1); push(edi);                              /* push edi */
            ii(0x1013_e77c, 1); push(ebp);                              /* push ebp */
            ii(0x1013_e77d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_e77f, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x1013_e785, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_e788, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_e78b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_e78e, 4); cmp(memb[ds, eax + 0xa], 0x3);          /* cmp byte [eax+0xa], 0x3 */
            ii(0x1013_e792, 2); if(jnz(0x1013_e79d, 0x9)) goto l_0x1013_e79d; /* jnz 0x1013e79d */
            ii(0x1013_e794, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_e797, 4); cmp(memd[ds, eax + 0x4], 0);            /* cmp dword [eax+0x4], 0x0 */
            ii(0x1013_e79b, 2); if(jnz(0x1013_e79f, 0x2)) goto l_0x1013_e79f; /* jnz 0x1013e79f */
        l_0x1013_e79d:
            ii(0x1013_e79d, 2); jmp(0x1013_e7bf, 0x20); goto l_0x1013_e7bf; /* jmp 0x1013e7bf */
        l_0x1013_e79f:
            ii(0x1013_e79f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_e7a2, 3); mov(eax, memd[ds, eax + 0x4]);          /* mov eax, [eax+0x4] */
            ii(0x1013_e7a5, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1013_e7a7, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_e7aa, 3); mov(eax, memd[ds, eax + 0x1c]);         /* mov eax, [eax+0x1c] */
            ii(0x1013_e7ad, 5); call(/* sys */ 0x1018_0dff, 0x4_264d);  /* call 0x10180dff */
            ii(0x1013_e7b2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_e7b4, 2); if(jnz(0x1013_e7bf, 0x9)) goto l_0x1013_e7bf; /* jnz 0x1013e7bf */
            ii(0x1013_e7b6, 4); mov(memb[ss, ebp - 0x10], 0xb);         /* mov byte [ebp-0x10], 0xb */
            ii(0x1013_e7ba, 5); jmp(0x1013_eb9c, 0x3dd); goto l_0x1013_eb9c; /* jmp 0x1013eb9c */
        l_0x1013_e7bf:
            ii(0x1013_e7bf, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_e7c2, 5); add(eax, 0x251);                        /* add eax, 0x251 */
            ii(0x1013_e7c7, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1013_e7ca, 7); mov(memd[ss, ebp - 0x14], 0x14);        /* mov dword [ebp-0x14], 0x14 */
        l_0x1013_e7d1:
            ii(0x1013_e7d1, 3); dec(memd[ss, ebp - 0x14]);              /* dec dword [ebp-0x14] */
            ii(0x1013_e7d4, 5); cmp(memw[ss, ebp - 0x14], -0x1 /* 0xff */); /* cmp word [ebp-0x14], 0xffff */
            ii(0x1013_e7d9, 2); if(jz(0x1013_e82f, 0x54)) goto l_0x1013_e82f; /* jz 0x1013e82f */
            ii(0x1013_e7db, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1013_e7de, 6); cmp(memd[ds, eax], 0xffff);             /* cmp dword [eax], 0xffff */
            ii(0x1013_e7e4, 2); if(jz(0x1013_e7fa, 0x14)) goto l_0x1013_e7fa; /* jz 0x1013e7fa */
            ii(0x1013_e7e6, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1013_e7e9, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1013_e7eb, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_e7ee, 3); mov(eax, memd[ds, eax + 0x1c]);         /* mov eax, [eax+0x1c] */
            ii(0x1013_e7f1, 5); call(/* sys */ 0x1018_0dff, 0x4_2609);  /* call 0x10180dff */
            ii(0x1013_e7f6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_e7f8, 2); if(jnz(0x1013_e7fc, 0x2)) goto l_0x1013_e7fc; /* jnz 0x1013e7fc */
        l_0x1013_e7fa:
            ii(0x1013_e7fa, 2); jmp(0x1013_e823, 0x27); goto l_0x1013_e823; /* jmp 0x1013e823 */
        l_0x1013_e7fc:
            ii(0x1013_e7fc, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1013_e7ff, 4); cmp(memb[ds, eax + 0x6], 0x3);          /* cmp byte [eax+0x6], 0x3 */
            ii(0x1013_e803, 2); if(jnz(0x1013_e818, 0x13)) goto l_0x1013_e818; /* jnz 0x1013e818 */
            ii(0x1013_e805, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_e808, 7); mov(memd[ds, eax + 0x4], 0);            /* mov dword [eax+0x4], 0x0 */
            ii(0x1013_e80f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_e812, 6); mov(memw[ds, eax + 0x10], 0xffff);      /* mov word [eax+0x10], 0xffff */
        l_0x1013_e818:
            ii(0x1013_e818, 3); mov(edx, memd[ss, ebp - 0x1c]);         /* mov edx, [ebp-0x1c] */
            ii(0x1013_e81b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_e81e, 5); call(0x1013_ce3f, -0x19e4);             /* call 0x1013ce3f */
        l_0x1013_e823:
            ii(0x1013_e823, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1013_e826, 7); add(memd[ss, ebp - 0x1c], 0x91);        /* add dword [ebp-0x1c], 0x91 */
            ii(0x1013_e82d, 2); jmp(0x1013_e7d1, -0x5e); goto l_0x1013_e7d1; /* jmp 0x1013e7d1 */
        l_0x1013_e82f:
            ii(0x1013_e82f, 7); mov(memd[ss, ebp - 0x14], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x1013_e836, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_e839, 5); add(eax, 0x251);                        /* add eax, 0x251 */
            ii(0x1013_e83e, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
        l_0x1013_e841:
            ii(0x1013_e841, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1013_e845, 3); cmp(eax, 0x14);                         /* cmp eax, 0x14 */
            ii(0x1013_e848, 2); if(jge(0x1013_e855, 0xb)) goto l_0x1013_e855; /* jge 0x1013e855 */
            ii(0x1013_e84a, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1013_e84d, 6); cmp(memd[ds, eax], 0xffff);             /* cmp dword [eax], 0xffff */
            ii(0x1013_e853, 2); if(jnz(0x1013_e857, 0x2)) goto l_0x1013_e857; /* jnz 0x1013e857 */
        l_0x1013_e855:
            ii(0x1013_e855, 2); jmp(0x1013_e869, 0x12); goto l_0x1013_e869; /* jmp 0x1013e869 */
        l_0x1013_e857:
            ii(0x1013_e857, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_e85a, 3); inc(memd[ss, ebp - 0x14]);              /* inc dword [ebp-0x14] */
            ii(0x1013_e85d, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1013_e860, 7); add(memd[ss, ebp - 0x1c], 0x91);        /* add dword [ebp-0x1c], 0x91 */
            ii(0x1013_e867, 2); jmp(0x1013_e841, -0x28); goto l_0x1013_e841; /* jmp 0x1013e841 */
        l_0x1013_e869:
            ii(0x1013_e869, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1013_e86d, 3); cmp(eax, 0x14);                         /* cmp eax, 0x14 */
            ii(0x1013_e870, 2); if(jnz(0x1013_e87b, 0x9)) goto l_0x1013_e87b; /* jnz 0x1013e87b */
            ii(0x1013_e872, 4); mov(memb[ss, ebp - 0x10], 0xb);         /* mov byte [ebp-0x10], 0xb */
            ii(0x1013_e876, 5); jmp(0x1013_eb9c, 0x321); goto l_0x1013_eb9c; /* jmp 0x1013eb9c */
        l_0x1013_e87b:
            ii(0x1013_e87b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_e87e, 3); mov(ebx, memd[ds, eax + 0x7]);          /* mov ebx, [eax+0x7] */
            ii(0x1013_e881, 3); sar(ebx, 0x18);                         /* sar ebx, 0x18 */
            ii(0x1013_e884, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_e887, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x1013_e88a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_e88d, 5); call(0x1013_eba7, 0x315);               /* call 0x1013eba7 */
            ii(0x1013_e892, 3); mov(memb[ss, ebp - 0xc], al);           /* mov [ebp-0xc], al */
            ii(0x1013_e895, 4); cmp(memb[ss, ebp - 0xc], 0);            /* cmp byte [ebp-0xc], 0x0 */
            ii(0x1013_e899, 2); if(jz(0x1013_e8a6, 0xb)) goto l_0x1013_e8a6; /* jz 0x1013e8a6 */
            ii(0x1013_e89b, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1013_e89e, 3); mov(memb[ss, ebp - 0x10], al);          /* mov [ebp-0x10], al */
            ii(0x1013_e8a1, 5); jmp(0x1013_eb9c, 0x2f6); goto l_0x1013_eb9c; /* jmp 0x1013eb9c */
        l_0x1013_e8a6:
            ii(0x1013_e8a6, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1013_e8a9, 3); add(eax, 0xb);                          /* add eax, 0xb */
            ii(0x1013_e8ac, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1013_e8af, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1013_e8b3, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_e8b6, 1); inc(edx);                               /* inc edx */
            ii(0x1013_e8b7, 3); mov(memd[ds, eax + 0x18], edx);         /* mov [eax+0x18], edx */
            ii(0x1013_e8ba, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_e8bd, 6); mov(edx, memd[ds, eax + 0xdb5]);        /* mov edx, [eax+0xdb5] */
            ii(0x1013_e8c3, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_e8c6, 3); mov(memd[ds, eax + 0x8], edx);          /* mov [eax+0x8], edx */
            ii(0x1013_e8c9, 2); mov(eax, ds);                           /* mov eax, ds */
            ii(0x1013_e8cb, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1013_e8ce, 6); mov(edx, memd[ds, edx + 0xdb1]);        /* mov edx, [edx+0xdb1] */
            ii(0x1013_e8d4, 3); mov(ebx, memd[ss, ebp - 0x18]);         /* mov ebx, [ebp-0x18] */
            ii(0x1013_e8d7, 4); mov(memw[ds, ebx + 0x4], ax);           /* mov [ebx+0x4], ax */
            ii(0x1013_e8db, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_e8de, 2); mov(memd[ds, eax], edx);                /* mov [eax], edx */
            ii(0x1013_e8e0, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_e8e3, 6); mov(memw[ds, eax + 0x20], 0);           /* mov word [eax+0x20], 0x0 */
            ii(0x1013_e8e9, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_e8ec, 7); mov(memd[ds, eax + 0x1c], 0);           /* mov dword [eax+0x1c], 0x0 */
            ii(0x1013_e8f3, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_e8f6, 7); test(memb[ds, eax + 0xdbd], 0x10);      /* test byte [eax+0xdbd], 0x10 */
            ii(0x1013_e8fd, 2); if(jz(0x1013_e90b, 0xc)) goto l_0x1013_e90b; /* jz 0x1013e90b */
            ii(0x1013_e8ff, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_e902, 7); mov(memd[ds, eax + 0x10], 0x3);         /* mov dword [eax+0x10], 0x3 */
            ii(0x1013_e909, 2); jmp(0x1013_e915, 0xa); goto l_0x1013_e915; /* jmp 0x1013e915 */
        l_0x1013_e90b:
            ii(0x1013_e90b, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_e90e, 7); mov(memd[ds, eax + 0x10], 0x2);         /* mov dword [eax+0x10], 0x2 */
        l_0x1013_e915:
            ii(0x1013_e915, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_e918, 6); mov(edx, memd[ds, eax + 0xdbd]);        /* mov edx, [eax+0xdbd] */
            ii(0x1013_e91e, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_e921, 3); mov(memd[ds, eax + 0x28], edx);         /* mov [eax+0x28], edx */
            ii(0x1013_e924, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_e927, 7); cmp(memd[ds, eax + 0xdb9], 0);          /* cmp dword [eax+0xdb9], 0x0 */
            ii(0x1013_e92e, 6); if(jz(0x1013_e9b9, 0x85)) goto l_0x1013_e9b9; /* jz 0x1013e9b9 */
            ii(0x1013_e934, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_e937, 4); cmp(memb[ds, eax + 0x19], 0x8);         /* cmp byte [eax+0x19], 0x8 */
            ii(0x1013_e93b, 2); if(jnz(0x1013_e981, 0x44)) goto l_0x1013_e981; /* jnz 0x1013e981 */
            ii(0x1013_e93d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_e940, 6); mov(edx, memd[ds, eax + 0xdb9]);        /* mov edx, [eax+0xdb9] */
            ii(0x1013_e946, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_e949, 3); sub(memd[ds, eax + 0x8], edx);          /* sub [eax+0x8], edx */
            ii(0x1013_e94c, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_e94f, 3); mov(ebx, memd[ds, eax + 0x8]);          /* mov ebx, [eax+0x8] */
            ii(0x1013_e952, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_e955, 6); mov(edx, memd[ds, eax + 0xdb1]);        /* mov edx, [eax+0xdb1] */
            ii(0x1013_e95b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_e95e, 6); add(edx, memd[ds, eax + 0xdb9]);        /* add edx, [eax+0xdb9] */
            ii(0x1013_e964, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_e967, 6); mov(eax, memd[ds, eax + 0xdb1]);        /* mov eax, [eax+0xdb1] */
            ii(0x1013_e96d, 5); call(Definitions.sys_memcpy, 0x2_74d9); /* call 0x10165e4b */
            ii(0x1013_e972, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_e975, 10); mov(memd[ds, eax + 0xdb9], 0);         /* mov dword [eax+0xdb9], 0x0 */
            ii(0x1013_e97f, 2); jmp(0x1013_e9af, 0x2e); goto l_0x1013_e9af; /* jmp 0x1013e9af */
        l_0x1013_e981:
            ii(0x1013_e981, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_e984, 4); or(memb[ds, eax + 0x28], 0x40);         /* or byte [eax+0x28], 0x40 */
            ii(0x1013_e988, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_e98b, 6); mov(edx, memd[ds, eax + 0xdb9]);        /* mov edx, [eax+0xdb9] */
            ii(0x1013_e991, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_e994, 3); mov(memd[ds, eax + 0x30], edx);         /* mov [eax+0x30], edx */
            ii(0x1013_e997, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_e99a, 6); mov(eax, memd[ds, eax + 0xdb5]);        /* mov eax, [eax+0xdb5] */
            ii(0x1013_e9a0, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1013_e9a3, 6); sub(eax, memd[ds, edx + 0xdb9]);        /* sub eax, [edx+0xdb9] */
            ii(0x1013_e9a9, 3); mov(edx, memd[ss, ebp - 0x18]);         /* mov edx, [ebp-0x18] */
            ii(0x1013_e9ac, 3); mov(memd[ds, edx + 0x34], eax);         /* mov [edx+0x34], eax */
        l_0x1013_e9af:
            ii(0x1013_e9af, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_e9b2, 7); mov(memd[ds, eax + 0xf], 0xffff_ffff);  /* mov dword [eax+0xf], 0xffffffff */
        l_0x1013_e9b9:
            ii(0x1013_e9b9, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_e9bc, 3); mov(edx, memd[ds, eax + 0xb]);          /* mov edx, [eax+0xb] */
            ii(0x1013_e9bf, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_e9c2, 3); mov(memd[ds, eax + 0x40], edx);         /* mov [eax+0x40], edx */
            ii(0x1013_e9c5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_e9c8, 4); cmp(memb[ds, eax + 0xa], 0x4);          /* cmp byte [eax+0xa], 0x4 */
            ii(0x1013_e9cc, 2); if(jnz(0x1013_ea05, 0x37)) goto l_0x1013_ea05; /* jnz 0x1013ea05 */
            ii(0x1013_e9ce, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_e9d1, 7); cmp(memd[ds, eax + 0xdc5], 0);          /* cmp dword [eax+0xdc5], 0x0 */
            ii(0x1013_e9d8, 2); if(jnz(0x1013_e9e6, 0xc)) goto l_0x1013_e9e6; /* jnz 0x1013e9e6 */
            ii(0x1013_e9da, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_e9dd, 7); mov(memd[ds, eax + 0xf], 0xffff_ffff);  /* mov dword [eax+0xf], 0xffffffff */
            ii(0x1013_e9e4, 2); jmp(0x1013_e9f6, 0x10); goto l_0x1013_e9f6; /* jmp 0x1013e9f6 */
        l_0x1013_e9e6:
            ii(0x1013_e9e6, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_e9e9, 3); mov(memw[ds, eax + 0x20], cs);          /* mov [eax+0x20], cs */
            ii(0x1013_e9ec, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_e9ef, 7); mov(memd[ds, eax + 0x1c], 0x1013_f2ce); /* mov dword [eax+0x1c], 0x1013f2ce */
        l_0x1013_e9f6:
            ii(0x1013_e9f6, 5); mov(eax, 0x36);                         /* mov eax, 0x36 */
            ii(0x1013_e9fb, 5); call(0x1007_5fdc, -0xc_8a24);           /* call 0x10075fdc */
            ii(0x1013_ea00, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1013_ea03, 2); jmp(0x1013_ea2a, 0x25); goto l_0x1013_ea2a; /* jmp 0x1013ea2a */
        l_0x1013_ea05:
            ii(0x1013_ea05, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_ea08, 4); cmp(memb[ds, eax + 0xa], 0x3);          /* cmp byte [eax+0xa], 0x3 */
            ii(0x1013_ea0c, 2); if(jnz(0x1013_ea1d, 0xf)) goto l_0x1013_ea1d; /* jnz 0x1013ea1d */
            ii(0x1013_ea0e, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1013_ea13, 5); call(0x1007_5fdc, -0xc_8a3c);           /* call 0x10075fdc */
            ii(0x1013_ea18, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1013_ea1b, 2); jmp(0x1013_ea2a, 0xd); goto l_0x1013_ea2a; /* jmp 0x1013ea2a */
        l_0x1013_ea1d:
            ii(0x1013_ea1d, 5); mov(eax, 0x37);                         /* mov eax, 0x37 */
            ii(0x1013_ea22, 5); call(0x1007_5fdc, -0xc_8a4b);           /* call 0x10075fdc */
            ii(0x1013_ea27, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
        l_0x1013_ea2a:
            ii(0x1013_ea2a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_ea2d, 3); mov(edx, memd[ss, ebp - 0x20]);         /* mov edx, [ebp-0x20] */
            ii(0x1013_ea30, 4); imul(edx, memd[ds, eax + 0x2]);         /* imul edx, [eax+0x2] */
            ii(0x1013_ea34, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_ea36, 5); mov(ebx, 0x64);                         /* mov ebx, 0x64 */
            ii(0x1013_ea3b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_ea3d, 2); div(ebx);                               /* div ebx */
            ii(0x1013_ea3f, 3); mov(edx, memd[ss, ebp - 0x18]);         /* mov edx, [ebp-0x18] */
            ii(0x1013_ea42, 3); mov(memd[ds, edx + 0x14], eax);         /* mov [edx+0x14], eax */
            ii(0x1013_ea45, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_ea48, 3); mov(edx, memd[ds, eax + 0xf]);          /* mov edx, [eax+0xf] */
            ii(0x1013_ea4b, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_ea4e, 3); mov(memd[ds, eax + 0xc], edx);          /* mov [eax+0xc], edx */
            ii(0x1013_ea51, 2); mov(ebx, ds);                           /* mov ebx, ds */
            ii(0x1013_ea53, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_ea56, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1013_ea59, 3); mov(edx, memd[ds, edx + 0x1c]);         /* mov edx, [edx+0x1c] */
            ii(0x1013_ea5c, 2); mov(ecx, ebx);                          /* mov ecx, ebx */
            ii(0x1013_ea5e, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1013_ea60, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_ea62, 5); call(/* sys */ 0x1017_fd5d, 0x4_12f6);  /* call 0x1017fd5d */
            ii(0x1013_ea67, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_ea69, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1013_ea6c, 2); mov(memd[ds, eax], edx);                /* mov [eax], edx */
            ii(0x1013_ea6e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_ea71, 3); mov(dx, memw[ds, eax]);                 /* mov dx, [eax] */
            ii(0x1013_ea74, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1013_ea77, 4); mov(memw[ds, eax + 0x4], dx);           /* mov [eax+0x4], dx */
            ii(0x1013_ea7b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_ea7e, 3); mov(dl, memb[ds, eax + 0xa]);           /* mov dl, [eax+0xa] */
            ii(0x1013_ea81, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1013_ea84, 3); mov(memb[ds, eax + 0x6], dl);           /* mov [eax+0x6], dl */
            ii(0x1013_ea87, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_ea8a, 3); mov(edx, memd[ds, eax + 0x2]);          /* mov edx, [eax+0x2] */
            ii(0x1013_ea8d, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1013_ea90, 3); mov(memd[ds, eax + 0x7f], edx);         /* mov [eax+0x7f], edx */
            ii(0x1013_ea93, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_ea96, 3); mov(edx, memd[ds, eax + 0x6]);          /* mov edx, [eax+0x6] */
            ii(0x1013_ea99, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1013_ea9c, 6); mov(memd[ds, eax + 0x83], edx);         /* mov [eax+0x83], edx */
            ii(0x1013_eaa2, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_eaa5, 4); mov(dx, memw[ds, eax + 0x13]);          /* mov dx, [eax+0x13] */
            ii(0x1013_eaa9, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1013_eaac, 4); mov(memw[ds, eax + 0x7], dx);           /* mov [eax+0x7], dx */
            ii(0x1013_eab0, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_eab3, 4); mov(dx, memw[ds, eax + 0x15]);          /* mov dx, [eax+0x15] */
            ii(0x1013_eab7, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1013_eaba, 4); mov(memw[ds, eax + 0x9], dx);           /* mov [eax+0x9], dx */
            ii(0x1013_eabe, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_eac1, 3); mov(eax, memd[ds, eax + 0xf]);          /* mov eax, [eax+0xf] */
            ii(0x1013_eac4, 3); mov(edx, memd[ss, ebp - 0x1c]);         /* mov edx, [ebp-0x1c] */
            ii(0x1013_eac7, 6); mov(memd[ds, edx + 0x87], eax);         /* mov [edx+0x87], eax */
            ii(0x1013_eacd, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1013_ead0, 10); mov(memd[ds, eax + 0x8b], 0);          /* mov dword [eax+0x8b], 0x0 */
            ii(0x1013_eada, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_eadd, 4); mov(ax, memw[ds, eax + 0x17]);          /* mov ax, [eax+0x17] */
            ii(0x1013_eae1, 3); mov(edx, memd[ss, ebp - 0x1c]);         /* mov edx, [ebp-0x1c] */
            ii(0x1013_eae4, 7); mov(memw[ds, edx + 0x8f], ax);          /* mov [edx+0x8f], ax */
            ii(0x1013_eaeb, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_eaee, 3); mov(al, memb[ds, eax + 0xa]);           /* mov al, [eax+0xa] */
            ii(0x1013_eaf1, 3); mov(memb[ss, ebp - 0x24], al);          /* mov [ebp-0x24], al */
            ii(0x1013_eaf4, 5); jmp(0x1013_eb72, 0x79); goto l_0x1013_eb72; /* jmp 0x1013eb72 */
        l_0x1013_eaf9:
            ii(0x1013_eaf9, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1013_eafc, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1013_eaff, 3); mov(memd[ds, edx + 0x4], eax);          /* mov [edx+0x4], eax */
            ii(0x1013_eb02, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_eb05, 3); mov(dx, memw[ds, eax]);                 /* mov dx, [eax] */
            ii(0x1013_eb08, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_eb0b, 4); mov(memw[ds, eax + 0x10], dx);          /* mov [eax+0x10], dx */
            ii(0x1013_eb0f, 5); jmp(0x1013_eb98, 0x84); goto l_0x1013_eb98; /* jmp 0x1013eb98 */
        l_0x1013_eb14:
            ii(0x1013_eb14, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1013_eb17, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1013_eb1a, 2); mov(memd[ds, edx], eax);                /* mov [edx], eax */
            ii(0x1013_eb1c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_eb1f, 3); mov(dx, memw[ds, eax]);                 /* mov dx, [eax] */
            ii(0x1013_eb22, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_eb25, 4); mov(memw[ds, eax + 0xc], dx);           /* mov [eax+0xc], dx */
            ii(0x1013_eb29, 5); jmp(0x1013_eb98, 0x6a); goto l_0x1013_eb98; /* jmp 0x1013eb98 */
        l_0x1013_eb2e:
            ii(0x1013_eb2e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_eb31, 7); cmp(memd[ds, eax + 0xda5], 0);          /* cmp dword [eax+0xda5], 0x0 */
            ii(0x1013_eb38, 2); if(jz(0x1013_eb62, 0x28)) goto l_0x1013_eb62; /* jz 0x1013eb62 */
            ii(0x1013_eb3a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_eb3d, 6); mov(eax, memd[ds, eax + 0xda5]);        /* mov eax, [eax+0xda5] */
            ii(0x1013_eb43, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1013_eb45, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1013_eb48, 2); cmp(edx, memd[ds, eax]);                /* cmp edx, [eax] */
            ii(0x1013_eb4a, 2); if(jz(0x1013_eb62, 0x16)) goto l_0x1013_eb62; /* jz 0x1013eb62 */
            ii(0x1013_eb4c, 5); call(0x1014_82f4, 0x97a3);              /* call 0x101482f4 */
            ii(0x1013_eb51, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_eb53, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_eb56, 6); mov(eax, memd[ds, eax + 0xda5]);        /* mov eax, [eax+0xda5] */
            ii(0x1013_eb5c, 6); mov(memd[ds, eax + 0x8b], edx);         /* mov [eax+0x8b], edx */
        l_0x1013_eb62:
            ii(0x1013_eb62, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1013_eb65, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1013_eb68, 6); mov(memd[ds, edx + 0xda5], eax);        /* mov [edx+0xda5], eax */
            ii(0x1013_eb6e, 2); jmp(0x1013_eb98, 0x28); goto l_0x1013_eb98; /* jmp 0x1013eb98 */
        l_0x1013_eb70:
            ii(0x1013_eb70, 2); jmp(0x1013_eb98, 0x26); goto l_0x1013_eb98; /* jmp 0x1013eb98 */
        l_0x1013_eb72:
            ii(0x1013_eb72, 3); mov(al, memb[ss, ebp - 0x24]);          /* mov al, [ebp-0x24] */
            ii(0x1013_eb75, 3); mov(memb[ss, ebp - 0x28], al);          /* mov [ebp-0x28], al */
            ii(0x1013_eb78, 4); cmp(memb[ss, ebp - 0x28], 0x3);         /* cmp byte [ebp-0x28], 0x3 */
            ii(0x1013_eb7c, 2); if(jb(0x1013_eb90, 0x12)) goto l_0x1013_eb90; /* jb 0x1013eb90 */
            ii(0x1013_eb7e, 4); cmp(memb[ss, ebp - 0x28], 0x3);         /* cmp byte [ebp-0x28], 0x3 */
            ii(0x1013_eb82, 6); if(jbe(0x1013_eaf9, -0x8f)) goto l_0x1013_eaf9; /* jbe 0x1013eaf9 */
            ii(0x1013_eb88, 4); cmp(memb[ss, ebp - 0x28], 0x4);         /* cmp byte [ebp-0x28], 0x4 */
            ii(0x1013_eb8c, 2); if(jz(0x1013_eb14, -0x7a)) goto l_0x1013_eb14; /* jz 0x1013eb14 */
            ii(0x1013_eb8e, 2); jmp(0x1013_eb70, -0x20); goto l_0x1013_eb70; /* jmp 0x1013eb70 */
        l_0x1013_eb90:
            ii(0x1013_eb90, 4); cmp(memb[ss, ebp - 0x28], 0x1);         /* cmp byte [ebp-0x28], 0x1 */
            ii(0x1013_eb94, 2); if(jz(0x1013_eb2e, -0x68)) goto l_0x1013_eb2e; /* jz 0x1013eb2e */
            ii(0x1013_eb96, 2); jmp(0x1013_eb70, -0x28); goto l_0x1013_eb70; /* jmp 0x1013eb70 */
        l_0x1013_eb98:
            ii(0x1013_eb98, 4); mov(memb[ss, ebp - 0x10], 0);           /* mov byte [ebp-0x10], 0x0 */
        l_0x1013_eb9c:
            ii(0x1013_eb9c, 3); mov(al, memb[ss, ebp - 0x10]);          /* mov al, [ebp-0x10] */
            ii(0x1013_eb9f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_eba1, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_eba2, 1); pop(edi);                               /* pop edi */
            ii(0x1013_eba3, 1); pop(esi);                               /* pop esi */
            ii(0x1013_eba4, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_eba5, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_eba6, 1); ret();                                  /* ret */
        }
    }
}
