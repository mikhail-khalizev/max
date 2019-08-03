using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cfccbe08-da8e-4d0a-bc99-147367d90fb3")]
        public void Method_1011_bfbf()
        {
            ii(0x1011_bfbf, 5); pushd(0x44);                            /* push 0x44 */
            ii(0x1011_bfc4, 5); calld(Definitions.sys_check_available_stack_size, 0x49d89); /* call 0x10165d52 */
            ii(0x1011_bfc9, 1); pushd(esi);                             /* push esi */
            ii(0x1011_bfca, 1); pushd(edi);                             /* push edi */
            ii(0x1011_bfcb, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_bfcc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_bfce, 6); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x1011_bfd4, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_bfd7, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1011_bfda, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1011_bfdd, 3); mov(memb_a32[ss, ebp - 0x4], cl);       /* mov [ebp-0x4], cl */
            ii(0x1011_bfe0, 5); calld(0x1012_0648, 0x4663);             /* call 0x10120648 */
            ii(0x1011_bfe5, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_bfe8, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_bfeb, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1011_bfee, 5); calld(0x1012_05f4, 0x4601);             /* call 0x101205f4 */
            ii(0x1011_bff3, 3); sub(eax, 0xe);                          /* sub eax, 0xe */
            ii(0x1011_bff6, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_bff9, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1011_bffc, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1011_bfff, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_c002, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x1011_c005, 5); calld(Definitions.my_ctor_0x101b4184, -0xa551a); /* call 0x10076af0 */
            ii(0x1011_c00a, 3); sub(eax, 0x1e);                         /* sub eax, 0x1e */
            ii(0x1011_c00d, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_c010, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1011_c013, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1011_c016, 3); mov(memb_a32[ds, edx + 0x22], al);      /* mov [edx+0x22], al */
            ii(0x1011_c019, 5); mov(eax, memd_a32[ds, 0x101c_8170]);    /* mov eax, [0x101c8170] */
            ii(0x1011_c01e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_c021, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_c024, 5); calld(Definitions.sys_new_arr, 0x49fe7); /* call 0x10166010 */
            ii(0x1011_c029, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_c02b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_c02e, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
            ii(0x1011_c030, 5); mov(eax, memd_a32[ds, 0x101c_8170]);    /* mov eax, [0x101c8170] */
            ii(0x1011_c035, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_c038, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_c03b, 5); calld(Definitions.sys_new_arr, 0x49fd0); /* call 0x10166010 */
            ii(0x1011_c040, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_c042, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_c045, 3); mov(memd_a32[ds, eax + 0x4], edx);      /* mov [eax+0x4], edx */
            ii(0x1011_c048, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x1011_c04f, 2); jmpd(0x1011_c057, 0x6); goto l_0x1011_c057; /* jmp 0x1011c057 */
        l_0x1011_c051:
            ii(0x1011_c051, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1011_c054, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
        l_0x1011_c057:
            ii(0x1011_c057, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1011_c05a, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x1011_c061, 6); if(jged(0x1011_c10d, 0xa6)) goto l_0x1011_c10d; /* jge 0x1011c10d */
            ii(0x1011_c067, 5); mov(eax, memd_a32[ds, 0x101c_8172]);    /* mov eax, [0x101c8172] */
            ii(0x1011_c06c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_c06f, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_c071, 5); calld(Definitions.sys_new_arr, 0x49f9a); /* call 0x10166010 */
            ii(0x1011_c076, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_c078, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1011_c07c, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_c07f, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1011_c081, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_c084, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_c086, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1011_c088, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
            ii(0x1011_c08a, 5); mov(eax, memd_a32[ds, 0x101c_8172]);    /* mov eax, [0x101c8172] */
            ii(0x1011_c08f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_c092, 5); calld(Definitions.sys_new_arr, 0x49f79); /* call 0x10166010 */
            ii(0x1011_c097, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_c099, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1011_c09d, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_c0a0, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1011_c0a2, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_c0a5, 3); mov(eax, memd_a32[ds, eax + 0x4]);      /* mov eax, [eax+0x4] */
            ii(0x1011_c0a8, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1011_c0aa, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
            ii(0x1011_c0ac, 6); mov(ebx, memd_a32[ds, 0x101c_8172]);    /* mov ebx, [0x101c8172] */
            ii(0x1011_c0b2, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1011_c0b5, 5); mov(edx, 0xff);                         /* mov edx, 0xff */
            ii(0x1011_c0ba, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1011_c0be, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_c0c1, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1011_c0c3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_c0c6, 3); mov(eax, memd_a32[ds, eax + 0x4]);      /* mov eax, [eax+0x4] */
            ii(0x1011_c0c9, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1011_c0cb, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_c0cd, 5); calld(Definitions.sys_memset, 0x49d0e); /* call 0x10165de0 */
            ii(0x1011_c0d2, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1011_c0d6, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_c0d9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_c0db, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_c0de, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_c0e0, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_c0e2, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_c0e4, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1011_c0e7, 6); mov(ax, memw_a32[ds, 0x101c_8174]);     /* mov ax, [0x101c8174] */
            ii(0x1011_c0ed, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
        l_0x1011_c0f0:
            ii(0x1011_c0f0, 3); dec(memd_a32[ss, ebp - 0x20]);          /* dec dword [ebp-0x20] */
            ii(0x1011_c0f3, 5); cmp(memw_a32[ss, ebp - 0x20], -0x1 /* 0xff */); /* cmp word [ebp-0x20], 0xffff */
            ii(0x1011_c0f8, 2); if(jzd(0x1011_c108, 0xe)) goto l_0x1011_c108; /* jz 0x1011c108 */
            ii(0x1011_c0fa, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1011_c0fd, 4); add(memd_a32[ss, ebp - 0x1c], 0x2);     /* add dword [ebp-0x1c], 0x2 */
            ii(0x1011_c101, 5); mov(memw_a32[ds, eax], 0x3fff);         /* mov word [eax], 0x3fff */
            ii(0x1011_c106, 2); jmpd(0x1011_c0f0, -0x18); goto l_0x1011_c0f0; /* jmp 0x1011c0f0 */
        l_0x1011_c108:
            ii(0x1011_c108, 5); jmpd(0x1011_c051, -0xbc); goto l_0x1011_c051; /* jmp 0x1011c051 */
        l_0x1011_c10d:
            ii(0x1011_c10d, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1011_c110, 6); mov(memw_a32[ds, edx + 0xc], 0);        /* mov word [edx+0xc], 0x0 */
            ii(0x1011_c116, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1011_c119, 5); calld(Definitions.my_ctor_0x101b4184, -0xa562e); /* call 0x10076af0 */
            ii(0x1011_c11e, 6); mov(ax, memw_a32[ds, 0x101c_8172]);     /* mov ax, [0x101c8172] */
            ii(0x1011_c124, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1011_c127, 3); sub(ax, memw_a32[ds, edx]);             /* sub ax, [edx] */
            ii(0x1011_c12a, 4); mov(memw_a32[ss, ebp - 0x24], ax);      /* mov [ebp-0x24], ax */
            ii(0x1011_c12e, 6); mov(ax, memw_a32[ds, 0x101c_8174]);     /* mov ax, [0x101c8174] */
            ii(0x1011_c134, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1011_c137, 4); sub(ax, memw_a32[ds, edx + 0x2]);       /* sub ax, [edx+0x2] */
            ii(0x1011_c13b, 4); mov(memw_a32[ss, ebp - 0x22], ax);      /* mov [ebp-0x22], ax */
            ii(0x1011_c13f, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1011_c142, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1011_c145, 3); cmp(ax, memw_a32[ds, edx]);             /* cmp ax, [edx] */
            ii(0x1011_c148, 2); if(jged(0x1011_c154, 0xa)) goto l_0x1011_c154; /* jge 0x1011c154 */
            ii(0x1011_c14a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_c14d, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1011_c150, 4); mov(memw_a32[ss, ebp - 0x24], ax);      /* mov [ebp-0x24], ax */
        l_0x1011_c154:
            ii(0x1011_c154, 3); mov(eax, memd_a32[ss, ebp - 0x22]);     /* mov eax, [ebp-0x22] */
            ii(0x1011_c157, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1011_c15a, 4); cmp(ax, memw_a32[ds, edx + 0x2]);       /* cmp ax, [edx+0x2] */
            ii(0x1011_c15e, 2); if(jged(0x1011_c16b, 0xb)) goto l_0x1011_c16b; /* jge 0x1011c16b */
            ii(0x1011_c160, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_c163, 4); mov(ax, memw_a32[ds, eax + 0x2]);       /* mov ax, [eax+0x2] */
            ii(0x1011_c167, 4); mov(memw_a32[ss, ebp - 0x22], ax);      /* mov [ebp-0x22], ax */
        l_0x1011_c16b:
            ii(0x1011_c16b, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1011_c16e, 4); cmp(ax, memw_a32[ss, ebp - 0x22]);      /* cmp ax, [ebp-0x22] */
            ii(0x1011_c172, 2); if(jled(0x1011_c183, 0xf)) goto l_0x1011_c183; /* jle 0x1011c183 */
            ii(0x1011_c174, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1011_c177, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_c179, 3); mov(edx, memd_a32[ss, ebp - 0x22]);     /* mov edx, [ebp-0x22] */
            ii(0x1011_c17c, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_c17e, 3); mov(memd_a32[ss, ebp - 0x28], edx);     /* mov [ebp-0x28], edx */
            ii(0x1011_c181, 2); jmpd(0x1011_c190, 0xd); goto l_0x1011_c190; /* jmp 0x1011c190 */
        l_0x1011_c183:
            ii(0x1011_c183, 3); mov(eax, memd_a32[ss, ebp - 0x22]);     /* mov eax, [ebp-0x22] */
            ii(0x1011_c186, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_c188, 3); mov(edx, memd_a32[ss, ebp - 0x24]);     /* mov edx, [ebp-0x24] */
            ii(0x1011_c18b, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_c18d, 3); mov(memd_a32[ss, ebp - 0x28], edx);     /* mov [ebp-0x28], edx */
        l_0x1011_c190:
            ii(0x1011_c190, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x1011_c194, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_c196, 5); calld(Definitions.sys_new_arr, 0x49e75); /* call 0x10166010 */
            ii(0x1011_c19b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_c19d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_c1a0, 3); mov(memd_a32[ds, eax + 0x8], edx);      /* mov [eax+0x8], edx */
        l_0x1011_c1a3:
            ii(0x1011_c1a3, 3); dec(memd_a32[ss, ebp - 0x28]);          /* dec dword [ebp-0x28] */
            ii(0x1011_c1a6, 5); cmp(memw_a32[ss, ebp - 0x28], -0x1 /* 0xff */); /* cmp word [ebp-0x28], 0xffff */
            ii(0x1011_c1ab, 2); if(jzd(0x1011_c1c4, 0x17)) goto l_0x1011_c1c4; /* jz 0x1011c1c4 */
            ii(0x1011_c1ad, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x1011_c1b1, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_c1b3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_c1b5, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_c1b8, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x1011_c1bb, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_c1bd, 5); mov(memw_a32[ds, eax], 0x7fff);         /* mov word [eax], 0x7fff */
            ii(0x1011_c1c2, 2); jmpd(0x1011_c1a3, -0x21); goto l_0x1011_c1a3; /* jmp 0x1011c1a3 */
        l_0x1011_c1c4:
            ii(0x1011_c1c4, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_c1c7, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x1011_c1ca, 5); mov(memw_a32[ds, eax], 0);              /* mov word [eax], 0x0 */
            ii(0x1011_c1cf, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_c1d2, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1011_c1d5, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_c1d8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_c1da, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_c1dd, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_c1df, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_c1e1, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_c1e4, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_c1e6, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_c1e9, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_c1eb, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1011_c1ed, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_c1ef, 5); mov(memw_a32[ds, eax], 0);              /* mov word [eax], 0x0 */
            ii(0x1011_c1f4, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1011_c1f7, 5); calld(0x1012_04a4, 0x42a8);             /* call 0x101204a4 */
            ii(0x1011_c1fc, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_c1ff, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1011_c202, 4); mov(memw_a32[ss, ebp - 0x30], ax);      /* mov [ebp-0x30], ax */
            ii(0x1011_c206, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_c209, 4); mov(ax, memw_a32[ds, eax + 0x2]);       /* mov ax, [eax+0x2] */
            ii(0x1011_c20d, 4); mov(memw_a32[ss, ebp - 0x2e], ax);      /* mov [ebp-0x2e], ax */
            ii(0x1011_c211, 6); mov(memw_a32[ss, ebp - 0x2c], 0);       /* mov word [ebp-0x2c], 0x0 */
            ii(0x1011_c217, 3); lea(edx, ebp - 0x30);                   /* lea edx, [ebp-0x30] */
            ii(0x1011_c21a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_c21d, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1011_c220, 5); calld(0x1012_0584, 0x435f);             /* call 0x10120584 */
            ii(0x1011_c225, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_c228, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_c22b, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x1011_c22e, 5); calld(0x1008_8b44, -0x936ef);           /* call 0x10088b44 */
            ii(0x1011_c233, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_c236, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1011_c239, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1011_c23c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_c23e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_c23f, 1); popd(edi);                              /* pop edi */
            ii(0x1011_c240, 1); popd(esi);                              /* pop esi */
            ii(0x1011_c241, 1); retd(); return;                         /* ret */
        }
    }
}
